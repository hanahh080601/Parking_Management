using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using HeThongGiuXe.BLL;
using HeThongGiuXe.DAL;
using HeThongGiuXe.Utils;

namespace HeThongGiuXe.View
{
    public partial class CheckinForm : Form
    {
        private VideoCapture Capture;
        private ArduinoSerial ArduinoSerial;
        // This property use to make decision of checkin
        private Customer CurrentCustomer;
        private string CurrentPlate;
        public CheckinForm()
        {
            InitializeComponent();
            InitializeVideo("0");
            InitializeSerial("COM7", 9600);
            InitializeParkingList();
        }
        private void InitializeSerial(string port, int baud)
        {
            try
            {
                this.ArduinoSerial = new ArduinoSerial(port, baud, this.HandleNewCardID);
            }
            catch (Exception err)
            {
                SerialSettingForm form = new SerialSettingForm(InitializeSerial);
                form.ShowDialog(this);
            }
        }
        private void InitializeVideo(string cam)
        {
            this.lbPlate.Text = "";
            // Cam is device or file ?
            if (cam.All(c => Char.IsDigit(c)))
            {
                Capture = new VideoCapture(Convert.ToInt32(cam));
            } else
            {
                Capture = new VideoCapture(cam);
            }
            // Is camera connected ? 
            if (!Capture.IsOpened)
            {
                MessageBox.Show("Không thể kết nối đến camera, hãy thử chọn một thiết bị khác", "Lỗi thiết bị");
                return;
            }
            // What thing to do when have frame?
            Capture.ImageGrabbed += ShowFrame;
            // Start camera thread
            Capture.Start();
        }
        private void InitializeParkingList()
        {
            this.tableVehicleInPark.DataSource = 
                CheckInOutBLL.Instance.GetDataTableParkingHistories(hasCheckout:false);
            if (this.tableVehicleInPark.RowCount > 0)
            {
                this.tableVehicleInPark.FirstDisplayedScrollingRowIndex
                = this.tableVehicleInPark.RowCount - 1;
            }
            
        }
        private void ShowFrame(object sender, EventArgs e)
        {

            try
            {
                // Get frame from camera
                Mat m = new Mat();
                ((VideoCapture)(sender)).Retrieve(m);
                // Show frame
                this.imgCamera.Image = m.ToImage<Bgr, byte>().Resize(650, 400, Emgu.CV.CvEnum.Inter.Linear, true);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private async void HandleNewCardID(string ID)
        {
            // To using reference in another thread
            if (this.txtCard.InvokeRequired)
            {
                this.Invoke(new ArduinoSerial.LineReceivedEvent(HandleNewCardID), ID);
                return;
            }
            // Set to textfield
            this.txtCard.Text = ID;
            // Start 2 thread: Check card + Check plate
            await Task.WhenAll(TryGetPlate(), CheckCardStatus(ID));
            if ((this.checkAutoCheckin.Checked) 
                && (this.CurrentPlate != null)
                && (this.CurrentCustomer != null))
            {
                CheckIn();
            }
        }
        private void CleanCheckinInfo()
        {
            this.txtCard.Clear();
            this.txtPlate.Clear();
            this.lbStatusCard.Text = "Waiting";
            this.CurrentPlate = null;
            this.CurrentCustomer = null;
        }
        private async Task TryGetPlate()
        {
            // Check if exist camera
            if (!this.Capture.IsOpened)
            {
                this.lbPlate.Text = "Chưa kết nối đến camera";
                this.lbPlate.ForeColor = Color.Red;
                return;
            }
            // return;
            this.CurrentPlate = null;
            // Loading signal
            this.txtPlate.Text = "";
            this.lbPlate.Text = "Đang trích xuất...";
            this.lbPlate.ForeColor = Color.Yellow;
            this.txtPlate.ReadOnly = true;
            // Get capture image
            Mat m = new Mat();
            this.Capture.Retrieve(m);
            // Call API to get plate
            IList<Result> resutls = await APIPlateRecognizer.Instance.ReadPlateAsync(m.ToBitmap());

            this.txtPlate.ReadOnly = false;
            // Handle result
            if (resutls == null || resutls.Count == 0)
            {
                // Cannot get plate or no plate in image
                this.lbPlate.Text = "Không thể nhận dạng";
                this.lbPlate.ForeColor = Color.Red;
                this.CurrentPlate = null;
                return;
            }
            // If multiple plate
            if (resutls.Count > 1)
            {
                this.lbPlate.Text = "Quá nhiều biển số";
                this.lbPlate.ForeColor = Color.Red;
                return;
            }
            // Show plate
            this.txtPlate.Text = resutls[0].Plate;
            this.CurrentPlate = resutls[0].Plate;
            this.lbPlate.Text = "Hợp lệ";
            this.lbPlate.ForeColor = Color.Green;
            
        }
        private async Task CheckCardStatus(string cardID)
        {
            this.CurrentCustomer = null;
            // Loading signla
            this.lbStatusCard.Text = "...";
            // Check card
            Customer customer = CustomerBLL.Instance.GetCustomerByCardID(cardID);
            // Card is register?
            if (customer == null)
            {
                this.lbStatusCard.Text = "Chưa đăng ký";
                this.lbStatusCard.ForeColor = Color.Red;
                SystemSound.play(Sound.InvalidCard);
                return;
            }
            // Check if have not check out
            bool haveCheckout = CheckInOutBLL.Instance.HaveCheckout(customer);
            if (!haveCheckout)
            {
                this.lbStatusCard.Text = "Thẻ chưa lấy xe";
                this.lbStatusCard.ForeColor = Color.Yellow;
                SystemSound.play(Sound.UsedCard);
                return;
            }
            this.lbStatusCard.Text = customer.fullname;
            this.lbStatusCard.ForeColor = Color.Green;
            this.CurrentCustomer = customer;
            
        }
        private void CheckIn()
        {
            if ((this.CurrentCustomer == null) || (this.CurrentPlate == null))
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin thẻ hoặc biển số", "Lỗi thông tin");
                return;
            }
            try
            {
                CheckInOutBLL.Instance.CheckIn(this.CurrentCustomer, this.CurrentPlate);
            } catch (Exception err)
            {
                MessageBox.Show("Không thể thêm thông tin vào cơ sở dữ liệu", "Lỗi hệ thống");
                return;
            }
            SystemSound.play(Sound.Accept);
;           InitializeParkingList();
            CleanCheckinInfo();
        }
        public void btnTryGetPlate_Click(object sender, EventArgs e)
        {
            _ = TryGetPlate();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CheckIn();
        }

        private void btnSetingSerial_Click(object sender, EventArgs e)
        {
            SerialSettingForm form = new SerialSettingForm(InitializeSerial);
            form.ShowDialog(this);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.ArduinoSerial.SendMessage("1");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ArduinoSerial.SendMessage("0");
        }

        private void txtPlate_TextChanged(object sender, EventArgs e)
        {
            this.CurrentPlate = ((TextBox)(sender)).Text;
        }

        private void btnFilterWithPlate_Click(object sender, EventArgs e)
        {
            if (this.CurrentPlate == null)
            {
                MessageBox.Show("Biển số không hợp lệ", "Lỗi dữ liệu");
            }
            this.tableVehicleInPark.DataSource = CheckInOutBLL.Instance
                .GetDataTableParkingHistories(hasCheckout: false, plate: this.CurrentPlate);
        }

        private void btnFilterWithCard_Click(object sender, EventArgs e)
        {
            string cardId = this.txtCard.Text.Trim();
            Customer customer = CustomerBLL.Instance.GetCustomerByCardID(cardId);
            if (customer == null)
            {
                MessageBox.Show("Thẻ không hợp lệ", "Lỗi dữ liệu");
                return;
            }
            this.tableVehicleInPark.DataSource = CheckInOutBLL.Instance
                .GetDataTableParkingHistories(hasCheckout: false, customer_id: customer.ID_customer);
        }

        private void btlGetAllInPark_Click(object sender, EventArgs e)
        {
            InitializeParkingList();
        }

        private void btnSettingCamera_Click(object sender, EventArgs e)
        {
            SettingCamera form = new SettingCamera(InitializeVideo);
            form.ShowDialog();
        }

        private void CheckinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ArduinoSerial != null)
            {
                this.ArduinoSerial.Close();
            }
            if (this.Capture != null)
            {
                this.Capture.Dispose();
            }
        }
    }
}
