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
    public partial class ParkingPackageForm : Form
    {
        public ParkingPackageForm()
        {
            InitializeComponent();
            LoadPackageGridView();
        }

        private void LoadPackageGridView()
        {
            search(true, null);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ReloadCurrentForm();
        }

        private void ReloadCurrentForm()
        {
            bool isVisible = this.check_visible.Checked;
            string txtSearch = this.txt_search.Text.Trim().ToLower();
            search(isVisible, txtSearch);
        }

        private void search(bool isVisible, string txtSearch)
        {
            List<Parking_Package> list = ParkingPackageBLL.Instance().FindAll(isVisible, txtSearch);

            DataTable currentDTable = CreateDTablePackage();

            foreach (Parking_Package package in list)
            {
                DataRow dr = currentDTable.NewRow();
                dr[PackageDTableField.ID] = package.ID_package;
                dr[PackageDTableField.NAME] = package.name;
                dr[PackageDTableField.PRICE] = package.price;
                dr[PackageDTableField.DURATION] = package.duration;
                dr[PackageDTableField.VISIBLE] = package.visible;
                dr[PackageDTableField.DESCRIPTION] = package.description;

                currentDTable.Rows.Add(dr);
            }

            this.dtgv_package.DataSource = currentDTable;

            HideColumnPackageGridView();
        }

        private DataTable CreateDTablePackage()
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[] 
            { 
                new DataColumn(PackageDTableField.ID, typeof(int)),
                new DataColumn(PackageDTableField.NAME, typeof(string)),
                new DataColumn(PackageDTableField.PRICE, typeof(int)),
                new DataColumn(PackageDTableField.DURATION, typeof(int)),
                new DataColumn(PackageDTableField.VISIBLE, typeof(bool)),
                new DataColumn(PackageDTableField.DESCRIPTION, typeof(string))
            });

            return dt;
        }

        private void HideColumnPackageGridView()
        {
            this.dtgv_package.Columns[0].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPackageForm addForm = new AddPackageForm();
            addForm.pointToParkingPackage = new AddPackageForm.PointToParkingPackageForm(ReloadCurrentForm);
            addForm.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (this.dtgv_package.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn gói cần cập nhật dữ liệu");
                return;
            }

            DataGridViewRow row = this.dtgv_package.SelectedRows[0];
            int packageId = Convert.ToInt32(row.Cells[PackageDTableField.ID].Value);
            AddPackageForm addForm = new AddPackageForm(packageId);
            addForm.pointToParkingPackage = new AddPackageForm.PointToParkingPackageForm(ReloadCurrentForm);
            addForm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.dtgv_package.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn gói cần xóa dữ liệu");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.No)
            {
                return;
            }

            DataGridViewRow row = this.dtgv_package.SelectedRows[0];
            int packageId = Convert.ToInt32(row.Cells[PackageDTableField.ID].Value);

            bool result = ParkingPackageBLL.Instance().DeleteById(packageId);

            if (result)
            {
                MessageBox.Show("Xóa thành công!");
                ReloadCurrentForm();
            } else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }

    class PackageDTableField
    {
        public static string ID = "PACKAGE_ID";
        public static string NAME = "Tên gói";
        public static string PRICE = "Giá";
        public static string DURATION = "Thời lượng";
        public static string VISIBLE = "Visible";
        public static string DESCRIPTION = "Mô tả";
    }
}
