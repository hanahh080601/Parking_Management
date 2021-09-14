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

namespace HeThongGiuXe.View
{
    public partial class AddPackageForm : Form
    {
        public delegate void PointToParkingPackageForm();
        public PointToParkingPackageForm pointToParkingPackage { get; set; }

        private int packageId;
        public AddPackageForm(int packageId = 0)
        {
            InitializeComponent();
            this.packageId = packageId;

            if (this.packageId > 0)
            {
                LoadUpdateForm();
            }
        }

        private void LoadUpdateForm()
        {
            Parking_Package package = ParkingPackageBLL.Instance().FindById(this.packageId);
            this.txt_name.Text = package.name;
            this.rtxt_description.Text = package.description;
            this.txt_price.Text = package.price.ToString();
            this.txt_duration.Text = package.duration.ToString();
            this.check_visible.Checked = package.visible;

            this.btn_add.Text = "Cập nhật";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_name.Text = "";
            this.rtxt_description.Text = "";
            this.txt_price.Text = "";
            this.txt_duration.Text = "";
            this.check_visible.Checked = true;
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt_duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private bool isUpdateMode()
        {
            return this.packageId > 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text.Trim();
            string description = this.rtxt_description.Text;
            int price = 0;
            int duration = 0;
            bool isVisible = this.check_visible.Checked;

            if (name == "")
            {
                MessageBox.Show("Vui lòng không để trống tên!");
                return;
            }

            try
            {
                price = Convert.ToInt32(this.txt_price.Text);
                if (price % 1000 != 0)
                {
                    MessageBox.Show("Vui lòng nhập giá tiền là bội của 1000");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho giá!");
                return;
            }

            try
            {
                duration = Convert.ToInt32(this.txt_duration.Text);
                if (duration <= 0)
                {
                    MessageBox.Show("Vui lòng nhập thời lượng lớn hơn 0");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho thời lượng!");
                return;
            }

            Parking_Package package = new Parking_Package
            {
                name = name,
                description = description,
                price = price,
                duration = duration,
                visible = isVisible
            };

            if (isUpdateMode())
            {
                package.ID_package = this.packageId;

                bool result = ParkingPackageBLL.Instance().UpdatePackage(package);
                if (result == true)
                {
                    MessageBox.Show("Cập nhật gói thành công!");
                    pointToParkingPackage();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, cập nhật thất bại!! Vui lòng kiểm tra lại.");
                }
            } else
            {
                bool result = ParkingPackageBLL.Instance().CreatePackage(package);
                if (result == true)
                {
                    MessageBox.Show("Thêm gói mới thành công!");
                    pointToParkingPackage();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, thêm gói mới thất bại!! Vui lòng kiểm tra lại.");
                }
            }
            

        }

        
    }
}
