using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;
using HeThongGiuXe.BLL;

namespace HeThongGiuXe.BLL
{
    class PaymentBLL
    {
        private static PaymentBLL _instance { get; set; }
        public static PaymentBLL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PaymentBLL();
                }
                return _instance;
            }
        }

        private PaymentBLL()
        {

        }

        public void RegisterPackage(int packageId, int customerId)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                Customer customer = CustomerBLL.Instance.GetCustomerByID(customerId);
                Parking_Package package = ParkingPackageBLL.Instance().FindById(packageId);

                Payment payment = new Payment();
                payment.customer_id = customer.ID_customer;
                payment.description = package.name;
                payment.start_date = DateTime.Now.Date;
                payment.end_date = payment.start_date.AddDays(package.duration);
                payment.price = package.price;
                payment.paid_at = DateTime.Now;

                db.Payments.Add(payment);
                //commit
                db.SaveChanges();
            }
        }

        public bool PurchaseRegisteredPayment(int customerId, int paymentId)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                try
                {
                    Payment payment = db.Payments.Find(paymentId);
                    Customer customer = db.Customers.Find(customerId);

                    if (payment == null || customer == null)
                    {
                        return false;
                    }

                    payment.paid_at = DateTime.Now;

                    db.SaveChanges();
                    return true;
                } 
                catch (Exception ex)
                {
                    return false;
                }
            }

        }

        public List<Payment> GetCurrentRegisteredPackage(int customerId)
        {
            List<Payment> list = new List<Payment>();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                list = db.Payments.Where(payment => (payment.start_date <= DateTime.Now)
                                            && (payment.end_date >= DateTime.Now)
                                            && (payment.customer_id == customerId)).ToList();
            }

            return list;
        }

        public DataTable getAvailableAndUnpaidPackage(int customerId)
        {
            DataTable dt = CreatePurchaseDTable();
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Liệt kê nhưng payment chưa thanh toán
                List<Payment> listPayment = db.Payments.Where(payment => (payment.paid_at == null)
                                            && (payment.start_date <= DateTime.Now)
                                            //&& (payment.end_date >= DateTime.Now)
                                            && (payment.customer_id == customerId)).ToList();

                Customer customer = CustomerBLL.Instance.GetCustomerByID(customerId);

                if (customer != null)
                {
                    foreach (Payment payment in listPayment)
                    {
                        DataRow dr = dt.NewRow();
                        dr[PurchaseDTableField.ID_CUSTOMER] = customer.ID_customer;
                        dr[PurchaseDTableField.STUDENT_ID] = customer.student_id;
                        dr[PurchaseDTableField.NAME] = customer.fullname;
                        dr[PurchaseDTableField.PRICE] = payment.price;
                        dr[PurchaseDTableField.ID_PAYMENT] = payment.ID_payment;
                        dr[PurchaseDTableField.START_DATE] = payment.start_date.Date.ToString();
                        dr[PurchaseDTableField.END_DATE] = payment.end_date.Date.ToString();
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        public DataTable CreateRegisterDTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn(RegisterDTableField.ID_CUSTOMER, typeof(int)),
                new DataColumn(RegisterDTableField.ID_PACKAGE, typeof(int)),
                new DataColumn(RegisterDTableField.STUDENT_ID, typeof(string)),
                new DataColumn(RegisterDTableField.NAME, typeof(string)),
                new DataColumn(RegisterDTableField.PACKAGE, typeof(string)),
                new DataColumn(RegisterDTableField.PRICE, typeof(int))
            });
            return dt;
        }

        public DataTable GetAllPaymentOfDate(DateTime date)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn(PurchaseDTableField.STUDENT_ID, typeof(string)),
                new DataColumn(PurchaseDTableField.NAME, typeof(string)),
                new DataColumn(PurchaseDTableField.PRICE, typeof(int)),
                new DataColumn(PurchaseDTableField.START_DATE, typeof(string)),
                new DataColumn(PurchaseDTableField.END_DATE, typeof(string)),
                new DataColumn(PurchaseDTableField.DESCRIPTION_PAYMENT, typeof(string))
            });

            List<Payment> list = new List<Payment>();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                list = db.Payments.Where(payment => (
                    payment.paid_at.Value.Year == date.Year
                    && payment.paid_at.Value.Month == date.Month
                    && payment.paid_at.Value.Day == date.Day
                )).ToList();

                foreach (Payment payment in list)
                {
                    DataRow dr = dt.NewRow();
                    dr[PurchaseDTableField.STUDENT_ID] = payment.Customer.student_id;
                    dr[PurchaseDTableField.NAME] = payment.Customer.fullname;
                    dr[PurchaseDTableField.PRICE] = payment.price;
                    dr[PurchaseDTableField.START_DATE] = payment.start_date;
                    dr[PurchaseDTableField.END_DATE] = payment.end_date;
                    dr[PurchaseDTableField.DESCRIPTION_PAYMENT] = payment.description;

                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        public DataTable CreatePurchaseDTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn(PurchaseDTableField.ID_CUSTOMER, typeof(int)),
                new DataColumn(PurchaseDTableField.STUDENT_ID, typeof(string)),
                new DataColumn(PurchaseDTableField.NAME, typeof(string)),
                new DataColumn(PurchaseDTableField.PRICE, typeof(int)),
                new DataColumn(PurchaseDTableField.ID_PAYMENT, typeof(int)),
                new DataColumn(PurchaseDTableField.START_DATE, typeof(string)),
                new DataColumn(PurchaseDTableField.END_DATE, typeof(string)),
                new DataColumn(PurchaseDTableField.DESCRIPTION_PAYMENT, typeof(string))
            });
            return dt;
        }
    }

    class RegisterDTableField
    {
        public static string ID_CUSTOMER = "ID_CUSTOMER";
        public static string ID_PACKAGE = "ID_PACKAGE";
        public static string STUDENT_ID = "Mã sinh viên";
        public static string NAME = "Tên";
        public static string PACKAGE = "Gói";
        public static string PRICE = "Gía";
    }

    class PurchaseDTableField
    {
        public static string ID_CUSTOMER = "ID_CUSTOMER";
        public static string STUDENT_ID = "Mã sinh viên";
        public static string NAME = "Tên";
        public static string DESCRIPTION_PAYMENT = "Mô tả";
        public static string PRICE = "Gía";
        public static string ID_PAYMENT = "ID_PAYMENT";
        public static string START_DATE = "Ngày hiệu lực";
        public static string END_DATE = "Ngày hết hạn";
    }
}
