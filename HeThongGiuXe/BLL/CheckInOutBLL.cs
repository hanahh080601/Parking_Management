using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class CheckInOutBLL
    {
        public bool HaveCheckout(Customer customer)
        {
            bool notCheckOut;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                notCheckOut = db.Parking_History.Any(o => o.customer_id == customer.ID_customer
                                                            && o.check_out_at == null);
            }
            return !notCheckOut;
        }
        public void CheckIn(Customer customer, String plate)
        {
            Parking_History history = new Parking_History
            {
                customer_id = customer.ID_customer,
                is_payment = false,
                check_in_at = DateTime.Now,
                check_out_at = null,
                license_plate = plate,
                price = 0
            };
            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Parking_History.Add(history);
                db.SaveChanges();
            }
        }
        public Parking_History CheckOut(string plate, bool isPayment)
        {
            Parking_History result = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Parking_History.Where(
                    o => o.license_plate == plate && o.check_out_at == null
                    ).FirstOrDefault();
                if (result == default(Parking_History))
                {
                    return null;
                }
                // Set checkout time
                result.check_out_at = DateTime.Now;
                result.is_payment = isPayment;
                // Update price
                DateTime startTime = result.check_in_at;
                DateTime endTime = (DateTime)(result.check_out_at);
                result.price = CalculatePrice(startTime, endTime, (int)result.customer_id, db);
                // Save
                db.SaveChanges();
            }
            return result;
        }
        public bool Debit(Parking_History parking_History)
        {
            bool success = false;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                Parking_History p = db.Parking_History.Find(parking_History.ID_parking);
                if (p != null)
                {
                    success = true;
                    p.is_payment = false;
                    db.SaveChanges();
                }
            }
            return success;
        }
        public int CalculatePrice(DateTime startTime, DateTime endTime, int customerID, DatabaseEntities db)
        {
            int result = 0;
            while (startTime < endTime)
            {
                // Phase 1
                {
                    // check if in payment package
                    Payment paid = db.Payments.Where(o
                        => o.start_date <= startTime
                        && o.end_date >= startTime
                        && o.customer_id == customerID).FirstOrDefault();
                    if (paid != default(Payment))
                    {
                        startTime = paid.end_date;
                        startTime = startTime.AddSeconds(1);
                        continue;
                    }
                    // have special time
                    Unit_Price specialTime = db.Unit_Price.Where(o
                        => o.start_date <= startTime
                        && o.end_date >= startTime).FirstOrDefault();
                    if (specialTime != default(Unit_Price))
                    {
                        result += specialTime.price;
                        startTime = (DateTime)(specialTime.end_date);
                        startTime = startTime.AddSeconds(1);
                        continue;
                    }
                    // calc by day
                    int day = (int)startTime.DayOfWeek + 1; // Monday is 1 -> Monday is 2
                    Unit_Price priceInDay = db.Unit_Price.Where(o
                        => o.day_in_week == day
                        && o.start_time_in_day <= startTime.TimeOfDay
                        && o.end_time_in_day >= startTime.TimeOfDay).FirstOrDefault();
                    if (priceInDay != default(Unit_Price))
                    {
                        result += priceInDay.price;
                        startTime = new DateTime(
                        startTime.Year,
                        startTime.Month,
                        startTime.Day,
                        ((TimeSpan)(priceInDay.end_time_in_day)).Hours,
                        ((TimeSpan)(priceInDay.end_time_in_day)).Minutes,
                        ((TimeSpan)(priceInDay.end_time_in_day)).Seconds
                        );
                        startTime = startTime.AddSeconds(1);
                        continue;
                    }
                }
                // Phase 2
                {
                    // check if in payment package
                    Payment paid = db.Payments.Where(o
                        => o.start_date >= startTime
                        && o.start_date <= endTime
                        && o.customer_id == customerID).FirstOrDefault();
                    if (paid != default(Payment))
                    {
                        startTime = paid.end_date;
                        startTime = startTime.AddSeconds(1);
                        continue;
                    }
                    // have special time
                    Unit_Price specialTime = db.Unit_Price.Where(o
                        => o.start_date >= startTime
                        && o.start_date <= endTime).FirstOrDefault();
                    if (specialTime != default(Unit_Price))
                    {
                        result += specialTime.price;
                        startTime = (DateTime)(specialTime.end_date);
                        startTime = startTime.AddSeconds(1);
                        continue;
                    }
                    // calc by day
                    int day = (int)startTime.DayOfWeek + 1; // Monday is 1 -> Monday is 2
                    TimeSpan endTimeInDay = startTime.Date == endTime.Date
                        ? TimeSpan.Parse("23:59:59")
                        : endTime.TimeOfDay;
                    Unit_Price priceInDay = db.Unit_Price.Where(o
                        => o.day_in_week == day
                        && o.start_time_in_day >= startTime.TimeOfDay
                        && o.start_time_in_day <= endTimeInDay).FirstOrDefault();
                    if (priceInDay != default(Unit_Price))
                    {
                        result += priceInDay.price;
                        startTime = new DateTime(
                            startTime.Year,
                            startTime.Month,
                            startTime.Day,
                            ((TimeSpan)(priceInDay.end_time_in_day)).Hours,
                            ((TimeSpan)(priceInDay.end_time_in_day)).Minutes,
                            ((TimeSpan)(priceInDay.end_time_in_day)).Seconds
                        );
                        startTime = startTime.AddSeconds(1);
                        continue;
                    }
                }
                // Cannot calc fee -> try next day
                {
                    if (startTime.Date != endTime.Date)
                    {
                        startTime = startTime.AddDays(1);
                        startTime = new DateTime(
                            startTime.Year,
                            startTime.Month,
                            startTime.Day,
                            0,
                            0,
                            0
                        );
                        continue;
                    }
                }
                break;
            }
              
            return result;
        }
        public List<Parking_History> GetParkingHistories(
            Nullable<int> customer_id = null,
            string plate = null,
            Nullable<DateTime> start = null,
            Nullable<DateTime> end = null,
            Nullable<bool> isPayment = null,
            Nullable<bool> hasCheckout = null)
        {
            List<Parking_History> results = null ;
            using (DatabaseEntities db = new DatabaseEntities())
            {            
                results = db.Parking_History.Where(o
                    => (((customer_id == null) ? true : (o.customer_id == customer_id))
                    && ((plate == null) ? true : (o.license_plate == plate))
                    && ((start == null) ? true : (o.check_in_at >= start))
                    && ((end == null) ? true : (o.check_in_at <= end))
                    && ((isPayment == null) ? true : (o.is_payment == isPayment))
                    && ((hasCheckout == null) ? true :
                        ((hasCheckout == true && o.check_out_at != null)
                        || (hasCheckout == false && o.check_out_at == null))))
                ).ToList();
            }
            return results;
        }
        public Parking_History GetParkingHistory(
            Nullable<int> customer_id = null,
            string plate = null,
            Nullable<bool> hasCheckout = null)
        {
            Parking_History result = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Parking_History.Where(o
                    => (((customer_id == null) ? true : (o.customer_id == customer_id))
                    && ((plate == null) ? true : (o.license_plate == plate))
                    && ((hasCheckout == null) ? true :
                        ((hasCheckout == true && o.check_out_at != null)
                        || (hasCheckout == false && o.check_out_at == null))))
                ).FirstOrDefault();
            }
            return result == default(Parking_History) ? null : result;
        }
        public DataTable GetDataTableParkingHistories(
            Nullable<int> customer_id = null,
            string plate = null,
            Nullable<DateTime> start = null,
            Nullable<DateTime> end = null,
            Nullable<bool> isPayment = null,
            Nullable<bool> hasCheckout = null)
        {
            // Prepare table
            List<Parking_History> results = null;
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Họ & tên", typeof(string)),
                new DataColumn("Biển số", typeof(string)),
                new DataColumn("Giờ vào", typeof(DateTime)),
            });
            // Get data
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Get data
                results = db.Parking_History.Where(o
                    => (((customer_id == null) ? true : (o.customer_id == customer_id))
                    && ((plate == null) ? true : (o.license_plate.Contains(plate)))
                    && ((start == null) ? true : (o.check_in_at >= start))
                    && ((end == null) ? true : (o.check_in_at <= end))
                    && ((isPayment == null) ? true : (o.is_payment == isPayment))
                    && ((hasCheckout == null) ? true :
                        ((hasCheckout == true && o.check_out_at != null)
                        || (hasCheckout == false && o.check_out_at == null))))
                ).ToList();
                // Parse to table
                foreach (Parking_History item in results)
                {
                    DataRow newRow = table.NewRow();
                    newRow["ID"] = item.Customer.student_id;
                    newRow["Họ & tên"] = item.Customer.fullname;
                    newRow["Biển số"] = item.license_plate;
                    newRow["Giờ vào"] = item.check_in_at;
                    table.Rows.Add(newRow);
                }
            }
            return table;
        }
        // Singleton
        private CheckInOutBLL() { }
        public static CheckInOutBLL _Instance { get; set; }
        public static CheckInOutBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CheckInOutBLL();
                return _Instance;
            }
        }
    }


}
