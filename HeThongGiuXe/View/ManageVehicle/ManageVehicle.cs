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
    public partial class ManageVehicle : Form
    {
        public ManageVehicle()
        {
            InitializeComponent();
            InitializeSearchBox();
            InitializeHistoryList();
        }
        private void InitializeSearchBox()
        {
            this.txt_fullname.Text = null;
            this.txt_mssv.Text = null;
            this.txt_license_plates.Text = null;
            this.cb_date.Checked = false;
            this.rb_is_payment.Checked = false;
            this.rb_isnt_payment.Checked = false;
            this.rb_all_payment.Checked = true;
            this.rb_inpark.Checked = false;
            this.rb_outpark.Checked = false;
            this.rb_all_range.Checked = true;
        }
        private void InitializeHistoryList()
        {
            this.rb_all_range.Checked = true;
            this.rb_all_payment.Checked = true;
            this.dtgv_list_vehicle.DataSource = ParkingHistoryBLL.Instance.GetDataTableParkingHistories();
            setStatisticsInfo();
            // set view for table
            this.dtgv_list_vehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_list_vehicle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_list_vehicle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
 
        }
        private void setStatusBtn()
        {
            this.btnAll.Enabled = !this.btnAll.Enabled;
            this.btnClear.Enabled = !this.btnClear.Enabled;
            this.btnSearch.Enabled = !this.btnSearch.Enabled;
        }
        private void setStatisticsInfo()
        {
            this.lbTotal.Text = "Tổng số xe (hệ thống) : " +  ParkingHistoryBLL.Instance.getTotalHistory().ToString();
            this.lbTotalInPark.Text = "Tổng số xe (trong bãi) : " + ParkingHistoryBLL.Instance.getTotalInPark().ToString();
            this.lbTotalPaid.Text = "Tổng số lượt (đã thanh toán) : " +  ParkingHistoryBLL.Instance.getTotalPaid().ToString();
            this.lbTotalUnpaid.Text = "Tổng số lượt (chưa thanh toán) : " + ParkingHistoryBLL.Instance.getTotalUnPaid().ToString();
            this.lbTodayCheckin.Text = "Xe Vào : " + ParkingHistoryBLL.Instance.getTodayCheckin().ToString();
            this.lbTodayCheckout.Text = "Xe Ra : " + ParkingHistoryBLL.Instance.getTodayCheckout().ToString();
        }
        private void search()
        {
            setStatusBtn();
            string student_id = this.txt_mssv.Text;
            string fullname = this.txt_fullname.Text;
            string licence_plate = this.txt_license_plates.Text;
            Nullable<DateTime> start = this.dtp_start_day.Value;
            Nullable<DateTime> end = this.dtp_end_day.Value;
            Nullable<Boolean> isPayment = this.rb_is_payment.Checked;
            Nullable<Boolean> hasCheckout = this.rb_outpark.Checked;

            // reset to search with all history
            if (this.rb_all_range.Checked) hasCheckout = null;
            // reset to search with all is payment and isnt payment
            if (this.rb_all_payment.Checked) isPayment = null;
            // check if don't have date limit 
            if ( this.cb_date.Checked == false)
            {
                start = null;
                end = null;
            }
            this.dtgv_list_vehicle.DataSource =
            ParkingHistoryBLL.Instance.GetDataTableParkingHistories(customer_name: fullname, student_id: student_id, plate: licence_plate, start: start, end: end, isPayment: isPayment, hasCheckout: hasCheckout);
            this.lbTotal.Text += this.dtgv_list_vehicle.Rows.Count.ToString();
            setStatisticsInfo();
            setStatusBtn();
        }
        private void clear()
        {
            this.txt_fullname.Clear();
            this.txt_mssv.Clear();
            this.txt_license_plates.Clear();
            this.cb_date.Checked = false;
            this.rb_is_payment.Checked = false;
            this.rb_isnt_payment.Checked = false;
            this.rb_all_payment.Checked = true;
            this.rb_inpark.Checked = false;
            this.rb_outpark.Checked = false;
            this.rb_all_range.Checked = true;
        }
       

        private void cb_date_CheckedChanged(object sender, EventArgs e)
        {
            this.gb_date.Enabled = this.cb_date.Checked;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
            if (this.dtgv_list_vehicle.RowCount > 0)
            {
                this.dtgv_list_vehicle.FirstDisplayedScrollingRowIndex
                = this.dtgv_list_vehicle.RowCount - 1;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            search();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            clear();
            search();
        }

    }
}
