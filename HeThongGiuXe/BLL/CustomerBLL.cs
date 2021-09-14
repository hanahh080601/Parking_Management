using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class CustomerBLL
    {
        public void CreateCustomer(Customer customer)
        {
            Validator.ValidateCustomerBeforeInsert(customer);
            customer.password = AuthBLL.Instance.Encrypt(customer.password);
            using (DatabaseEntities db = new DatabaseEntities())
            {
                customer.created_at = DateTime.Now;
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }
        public List<Customer> GetCustomers(
            string fullname = null,
            string phone = null,
            string email = null,
            string studentID = null,
            string username = null
            )
        {
            List<Customer> results = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                results = db.Customers.Where(o
                    => (fullname == null ? true : o.fullname.Contains(fullname)) 
                    && (phone == null ? true : (o.phone == null ? false : o.phone.Contains(phone)))
                    && (email == null ? true : (o.email == null ? false : o.email.Contains(email)))
                    && (studentID == null ? true : (o.student_id == null ? false : o.student_id.Contains(studentID)))
                    && (username == null ? true : (o.username == null ? false : o.username.Contains(username)))
                ).ToList();
            }
            return results;
        }
        public DataTable GetDataTableCustomers(
            string fullname = null,
            string phone = null,
            string email = null,
            string studentID = null,
            string username = null
            )
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Họ và tên", typeof(string)),
                new DataColumn("Mã sinh viên", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("Số điện thoại", typeof(string)),
                new DataColumn("Tên tài khoản", typeof(string)),
                new DataColumn("Lượt gửi xe", typeof(int)),
                new DataColumn("Tạo lúc", typeof(DateTime)),
                new DataColumn("Cập nhật lúc", typeof(DateTime)),
                new DataColumn("Thanh toán", typeof(string)),
            });
            List<Customer> results = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                results = db.Customers.Where(o
                    => (fullname == null ? true : o.fullname.ToLower().Contains(fullname.ToLower()))
                    && (phone == null ? true : (o.phone == null ? false : o.phone.Contains(phone)))
                    && (email == null ? true : (o.email == null ? false : o.email.Contains(email)))
                    && (studentID == null ? true : (o.student_id == null ? false : o.student_id.Contains(studentID)))
                    && (username == null ? true : (o.username == null ? false : o.username.Contains(username)))
                ).ToList();

                foreach (Customer customer in results)
                {
                    DataRow row = table.NewRow();
                    row["ID"] = customer.ID_customer;
                    row["Họ và tên"] = customer.fullname;
                    row["Mã sinh viên"] = customer.student_id;
                    row["Email"] = customer.email;
                    row["Số điện thoại"] = customer.phone;
                    row["Tên tài khoản"] = customer.username;
                    row["Lượt gửi xe"] = customer.Parking_History.Count;
                    Payment lastPaid = customer.Payments.LastOrDefault();
                    if (lastPaid != default)
                    {
                        if (lastPaid.paid_at != null)
                        {
                            row["Thanh toán"] = lastPaid.end_date.ToString();
                        } else
                        {
                            row["Thanh toán"] = "Nợ tiền";
                        }
                        
                    }
                    if (customer.created_at != null)
                    {
                        row["Tạo lúc"] = customer.created_at;

                    }
                    if (customer.updated_at != null)
                    {
                        row["Cập nhật lúc"] = customer.updated_at;

                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public Customer GetCustomerByID(int ID)
        {
            Customer result = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Customers.Find(ID);
            }
            return result;
        }
        public void DeleteCustomer(int ID)
        {
            Customer customer = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // check if not checkout
                var parkingHistory = db.Parking_History.Where(o
                    => o.customer_id == ID
                    && o.check_out_at == null
                    ).FirstOrDefault();
                if (parkingHistory != default(Parking_History))
                {
                    throw new Exception("Tài khoản này chưa lấy xe trong bãi");
                }
                // check if not payment
                var payment = db.Payments.Where(o
                    => o.customer_id == ID
                    && o.paid_at == null
                    ).FirstOrDefault();
                if (payment != default(Payment))
                {
                    throw new Exception("Tài khoản này chưa thanh toán gói: " + payment.description);
                }
                // check if exist
                customer = db.Customers.Find(ID);
                if (customer != null) db.Customers.Remove(customer);
                db.SaveChanges();
            }
            if (customer == null) throw new Exception("Tài khoản không tồn tại");
        }
        public void UpdateCustomer(Customer customer)
        {
            Validator.ValidateCustomerBeforeUpdate(customer);
            Customer target = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                target = db.Customers.Find(customer.ID_customer);
                if (target != null)
                {
                    target.fullname = customer.fullname;
                    target.email = customer.email;
                    target.card_id = customer.card_id;
                    target.password = customer.password == null 
                        ? target.password
                        : AuthBLL.Instance.Encrypt(customer.password);
                    target.phone = customer.phone;
                    target.username = customer.username;
                    target.updated_at = DateTime.Now;
                    target.student_id = customer.student_id;
                    db.SaveChanges();
                }
            }
            if (target == null)
            {
                throw new Exception("Tài khoản không tồn tại");
            }
        }
        public Customer GetCustomerByCardID(string cardID)
        {
            Customer result;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Customers.Where(o => o.card_id == cardID)
                    .FirstOrDefault();
            }
            return (result == default(Customer)) ? null : result;
        }
        // Singleton
        private CustomerBLL() { }
        public static CustomerBLL _Instance { get; set; }
        public static CustomerBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CustomerBLL();
                return _Instance;
            }
        }
    }

    
}
