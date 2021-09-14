using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.BLL;
using HeThongGiuXe.DAL;
using HeThongGiuXe.Utils;

namespace HeThongGiuXe.View
{
    public partial class ManageCustomer : Form
    {
        private int? currentSelectedID = null;
        private ArduinoSerial ArduinoSerial;
        public ManageCustomer()
        {
            InitializeComponent();
            InitializePortList();
        }
        public void InitializePortList()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            this.cbPort.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                this.cbPort.SelectedIndex = 0;
            } 
        }
        private void InitializeSerial(string port=null, int baud=9600)
        { 
            try
            {
                this.ArduinoSerial = new ArduinoSerial(port, baud, this.HandleNewCardID);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không thể kết nối với đầu đọc thẻ từ, vui lòng kiểm tra và khởi động lại ứng dụng",
                                "Lỗi thiết bị");
                Console.WriteLine(err.Message);
            }
        }
        private void HandleNewCardID(string ID)
        {
            // To using reference in another thread
            if (this.txtCardID.InvokeRequired)
            {
                this.Invoke(new ArduinoSerial.LineReceivedEvent(HandleNewCardID), ID);
                return;
            }
            // Set to textfield
            this.txtCardID.Text = ID;
        }
      
        private void clearDetail()
        {
            this.txtCardID.Clear();
            this.txtEmail.Clear();
            this.txtFullname.Clear();
            this.txtPassword.Clear();
            this.txtPhone.Clear();
            this.txtStudentID.Clear();
            this.txtUsername.Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = this.btnShowAll.Enabled = false;
            try
            {
                this.tableCustomers.DataSource = CustomerBLL.Instance.GetDataTableCustomers();
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            this.tableCustomers.Columns[0].Visible = false;
            this.btnSearch.Enabled = this.btnShowAll.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = this.btnShowAll.Enabled = false;
            search();
            this.btnSearch.Enabled = this.btnShowAll.Enabled = true;

        }
        private void search()
        {
            string fullname = this.txtFullnameFilter.Text == "" ? null : this.txtFullnameFilter.Text;
            string email = this.txtEmailFilter.Text == "" ? null : this.txtEmailFilter.Text;
            string phone = this.txtPhoneFilter.Text == "" ? null : this.txtPhoneFilter.Text;
            string studentID = this.txtStudentIDFilter.Text == "" ? null : this.txtStudentIDFilter.Text;
            try
            {
                this.tableCustomers.DataSource = CustomerBLL.Instance.GetDataTableCustomers(
                fullname: fullname,
                email: email,
                phone: phone,
                studentID: studentID
                );
            } catch (Exception err)
            {

            }
            this.tableCustomers.Columns[0].Visible = false;
        }

        private void tableCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.tableCustomers.SelectedRows.Count == 0) return;
            int ID = Convert.ToInt32(this.tableCustomers.SelectedRows[0].Cells[0].Value);
            Customer customer = CustomerBLL.Instance.GetCustomerByID(ID);
            if (customer == null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Lỗi dữ liệu");
                return;
            }
            LoadDetail(customer);
        }
        private void LoadDetail(Customer customer)
        {
            this.btnOK.Text = "Cập nhật";
            this.currentSelectedID = customer.ID_customer;
            this.txtCardID.Text = customer.card_id;
            this.txtEmail.Text = customer.email;
            this.txtFullname.Text = customer.fullname;
            //this.txtPassword.Text = customer.password;
            this.txtPhone.Text = customer.phone;
            this.txtStudentID.Text = customer.student_id;
            this.txtUsername.Text = customer.username;
        }
        private Customer GetDetail()
        {
            return new Customer
            {
                username = this.txtUsername.Text.Trim().Length == 0 ? null : this.txtUsername.Text.Trim(),
                student_id = this.txtStudentID.Text.Trim().Length == 0 ? null : this.txtStudentID.Text.Trim(),
                card_id = this.txtCardID.Text.Trim().Length == 0 ? null : this.txtCardID.Text.Trim(),
                email = this.txtEmail.Text.Trim().Length == 0 ? null : this.txtEmail.Text.Trim(),
                fullname = this.txtFullname.Text.Trim(),
                password = this.txtPassword.Text.Trim().Length == 0? null : this.txtPassword.Text.Trim(),
                phone = this.txtPhone.Text.Trim().Length == 0? null : this.txtPhone.Text.Trim(),
            };
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearDetail();
            this.btnOK.Text = "Thêm";
            this.currentSelectedID = null;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Customer customer = GetDetail();
            if (this.currentSelectedID == null)
            {
                // Add
                try
                {
                    CustomerBLL.Instance.CreateCustomer(customer);
                } catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Lỗi thông tin");
                    return;
                }
                clearDetail();
            } else
            {
                // Update
                customer.ID_customer = (int)this.currentSelectedID;
                try
                {
                    CustomerBLL.Instance.UpdateCustomer(customer);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Lỗi thông tin");
                    return;
                }
                clearDetail();
                search();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedID == null) return;
            DialogResult confirmResult = MessageBox.Show("Bạn có chắn muốn xóa người này?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            try
            {
                CustomerBLL.Instance.DeleteCustomer((int)this.currentSelectedID);
                clearDetail();
                search();
            } catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi dữ liệu");
            }
        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ArduinoSerial != null)
            {
                this.ArduinoSerial.Close();
            }
            InitializeSerial(this.cbPort.Text, 9600);
        }

    }
}
