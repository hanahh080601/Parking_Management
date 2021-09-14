using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class ParkingHistoryBLL
    {

        public DataTable GetDataTableParkingHistories(
            string customer_name = null,
            string username = null,
            string plate = null,
            string student_id = null,
            Nullable<DateTime> start = null,
            Nullable<DateTime> end = null,
            Nullable<bool> isPayment = null,
            Nullable<bool> hasCheckout = null ,
            Nullable<DateTime> checkout_at = null)
        {
            // Prepare table

            List<Parking_History> results = null;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("Mã số sinh viên", typeof(string)),
                new DataColumn("Họ & tên", typeof(string)),
                new DataColumn("Biển số", typeof(string)),
                new DataColumn("Giờ vào", typeof(DateTime)),
                new DataColumn("Giờ ra", typeof(DateTime)),
                new DataColumn("Giá", typeof(string)),
                new DataColumn("Đã thanh toán", typeof(Boolean)),
            });
            // Get data
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Get data
                results = db.Parking_History.Where(o
                    => (
                    ((plate == null) ? true : (o.license_plate.Contains(plate)))
                    && ((customer_name == null) ? true : (o.Customer.fullname.Contains(customer_name)))
                    && ((username == null) ? true : (o.Customer.username.Contains(username)))
                     && ((student_id == null) ? true : (o.Customer.student_id.Contains(student_id)))
                    && ((start == null) ? true : (o.check_in_at >= start))
                    && ((end == null) ? true : (o.check_in_at <= end))
                     && ((checkout_at == null) ? true : (o.check_out_at >= checkout_at))
                    && ((isPayment == null) ? true : ( o.is_payment == isPayment))
                    && ((hasCheckout == null) ? true :
                        ((hasCheckout == true && o.check_out_at != null)
                        || (hasCheckout == false && o.check_out_at == null))))
                     
                ).ToList();
                // Parse to table
                foreach (Parking_History item in results)
                {
                    DataRow newRow = table.NewRow();
                    // check if user be deleted 
                    if( item?.Customer == null )
                    {
                        newRow["Mã số sinh viên"] = "Không xác định";
                        newRow["Họ & tên"] = "Không xác định";
                    }
                    else
                    {

                    newRow["Mã số sinh viên"] = item.Customer.student_id;
                    newRow["Họ & tên"] = item.Customer.fullname;
                    }
                    newRow["Biển số"] = item.license_plate;
                    newRow["Giờ vào"] = item.check_in_at;
                    // set value checkout if not checkout 
                    if( item.check_out_at != null)
                    {
                        newRow["Giờ ra"] = item.check_out_at;
                    }
                    newRow["Giá"] = item.price;
                    newRow["Đã thanh toán"] = item.is_payment;
                    table.Rows.Add(newRow);
                }
            }
            return table;
        }
        public int getTotalHistory()
        {
            DataTable table = this.GetDataTableParkingHistories();
            return table.Rows.Count;
        }
        public int getTotalPaid()
        {
            DataTable table = this.GetDataTableParkingHistories(isPayment:true);
            return table.Rows.Count;
        }
        public int getTotalUnPaid()
        {
            DataTable table = this.GetDataTableParkingHistories(isPayment: false);
            return table.Rows.Count;
        }
        public int getTotalInPark()
        {
            DataTable table = this.GetDataTableParkingHistories(hasCheckout: false);
            return table.Rows.Count;
        }

        public int getTodayCheckin()
        {
            DateTime today = DateTime.Now;
            DataTable table = this.GetDataTableParkingHistories(start: today.Date);
            return table.Rows.Count;
        }
        public int getTodayCheckout()
        {
            DateTime today = DateTime.Now.Date;
            DataTable table = this.GetDataTableParkingHistories(checkout_at: today);
            return table.Rows.Count;
        }
        
        // Singleton
        private ParkingHistoryBLL() { }
        public static ParkingHistoryBLL _Instance { get; set; }
        public static ParkingHistoryBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new ParkingHistoryBLL();
                return _Instance;
            }
          
        }

        public DataTable GetCheckoutParkingHistoryOfDay(
            Nullable<bool> isPayment = null,
            Nullable<DateTime> checkout_at = null)
        {
            // Prepare table

            List<Parking_History> results = null;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("Mã số sinh viên", typeof(int)),
                new DataColumn("Họ & tên", typeof(string)),
                new DataColumn("Biển số", typeof(string)),
                new DataColumn("Giờ vào", typeof(DateTime)),
                new DataColumn("Giờ ra", typeof(DateTime)),
                new DataColumn("Giá", typeof(string)),
            });
            // Get data
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Get data
                results = db.Parking_History.Where(o
                    => (
                    ((isPayment == null || isPayment == false) ?  true : o.price > 0)
                    && (o.check_out_at.Value.Year == checkout_at.Value.Year 
                        && o.check_out_at.Value.Month == checkout_at.Value.Month
                        && o.check_out_at.Value.Day == checkout_at.Value.Day)
                    )
                ).ToList();
                // Parse to table
                foreach (Parking_History item in results)
                {
                    DataRow newRow = table.NewRow();
                    newRow[ParkingHistoryDTableField.STUDENT_ID] = item.Customer.student_id;
                    newRow[ParkingHistoryDTableField.CUSTOMER_NAME] = item.Customer.fullname;
                    newRow[ParkingHistoryDTableField.PLATE_NUM] = item.license_plate;
                    newRow[ParkingHistoryDTableField.CHECK_IN] = item.check_in_at;
                    // set value checkout if not checkout 
                    if (item.check_out_at != null)
                    {
                        newRow[ParkingHistoryDTableField.CHECK_OUT] = item.check_out_at;
                    }
                    newRow[ParkingHistoryDTableField.PRICE] = item.price;
                    table.Rows.Add(newRow);
                }
            }
            return table;
        }
    }

    class ParkingHistoryDTableField
    {
        public static string STUDENT_ID = "Mã số sinh viên";
        public static string CUSTOMER_NAME = "Họ & tên";
        public static string PLATE_NUM = "Biển số";
        public static string CHECK_IN = "Giờ vào";
        public static string CHECK_OUT = "Giờ ra";
        public static string PRICE = "Giá";
    }
}
  
