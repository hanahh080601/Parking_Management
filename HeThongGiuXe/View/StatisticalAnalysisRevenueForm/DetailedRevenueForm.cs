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

namespace HeThongGiuXe.View
{
    public partial class DetailedRevenueForm : Form
    {

        public DetailedRevenueForm(int month, int year)
        {
            InitializeComponent();
            LoadDataRevenueEachDayInMonth(month,year);
            SetDateForDateTimePicker(1, month, year);
        }

        private void LoadDataRevenueEachDayInMonth(int month, int year)
        {
            this.dtgv_revenue.DataSource = AnalysisRevenueBLL.Instance().GetDataTableRevenue(month, year);
        }

        private void SetDateForDateTimePicker(int day, int month, int year)
        {
            this.dtpk_1.Value = new DateTime(year, month, day);
        }

        private void dtgv_revenue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dtgv_revenue.SelectedRows.Count > 0)
            {
                int day = Convert.ToInt32(this.dtgv_revenue.SelectedRows[0].Cells[RevenueEachDayDTableField.DAY].Value);
                int month = this.dtpk_1.Value.Month;
                int year = this.dtpk_1.Value.Year;
                DateTime date = new DateTime(year, month, day);

                this.dtgv_parking_payment.DataSource = ParkingHistoryBLL.Instance.GetCheckoutParkingHistoryOfDay(true, date);

                this.dtgv_package_payment.DataSource = PaymentBLL.Instance.GetAllPaymentOfDate(date);
            }
        }

        private void dtpk_1_ValueChanged(object sender, EventArgs e)
        {
            int month = this.dtpk_1.Value.Month;
            int year = this.dtpk_1.Value.Year;
            LoadDataRevenueEachDayInMonth(month, year);
            this.dtgv_package_payment.DataSource = new DataTable();
            this.dtgv_parking_payment.DataSource = new DataTable();
        }
    }
}
