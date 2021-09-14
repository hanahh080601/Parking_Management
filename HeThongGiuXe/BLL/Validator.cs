using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class Validator
    {

        public static void ValidatePackageBeforeInsert(Parking_Package package)
        {
            if (package.name == null || package.name == "")
            {
                throw new ArgumentException("Tên gói không được để trống");
            }

            if (package.price <= 0 || (package.price % 1000 != 0))
            {
                throw new ArgumentException("Giá gói phải là một số nguyên dương bội của 1000");
            }

            if (package.duration <= 0)
            {
                throw new ArgumentException("Thời lượng phải là một số nguyên dương");
            }

        }
        public static void ValidateCustomerBeforeInsert(Customer customer)
        {
            // Validate basic info 
            ValidateCustomer(customer);
            // Validate password 
            if (customer.password == null)
            {
                throw new ArgumentException("Mật khẩu là bắt buộc");
            }
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Validate if duplicate in DB
                if (db.Customers.Any(o => o.card_id == customer.card_id))
                {
                    throw new ArgumentException("Thẻ đã được đăng ký");
                }
                if ((customer.student_id != null) &&
                    (db.Customers.Any(o => o.student_id == customer.student_id)))
                {
                    throw new ArgumentException("Mã số sinh viên đã được đăng ký");
                }
                if ((customer.phone != null) &&
                    (db.Customers.Any(o => o.phone == customer.phone)))
                {
                    throw new ArgumentException("Số điện thoại đã được đăng ký");
                }
                if ((customer.email != null) &&
                    (db.Customers.Any(o => o.email == customer.email)))
                {
                    throw new ArgumentException("Email đã được đăng ký");
                }
                if ((customer.username != null) &&
                    (db.Customers.Any(o => o.username == customer.username)))
                {
                    throw new ArgumentException("Tên tài khoản đã được sử dụng");
                }
            }
        }
        public static void ValidateCustomerBeforeUpdate(Customer customer)
        {
            ValidateCustomer(customer);
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Validate if duplicate in DB
                if (db.Customers.Any(o => o.card_id == customer.card_id && 
                                          o.ID_customer != customer.ID_customer))
                {
                    throw new ArgumentException("Thẻ đã được đăng ký");
                }
                if ((customer.student_id != null) &&
                    (db.Customers.Any(o => o.student_id == customer.student_id &&
                                      o.ID_customer != customer.ID_customer)))
                {
                    throw new ArgumentException("Mã số sinh viên đã được đăng ký");
                }
                if ((customer.phone != null) &&
                    (db.Customers.Any(o => o.phone == customer.phone &&
                                           o.ID_customer != customer.ID_customer)))
                {
                    throw new ArgumentException("Số điện thoại đã được đăng ký");
                }
                if ((customer.email != null) &&
                    (db.Customers.Any(o => o.email == customer.email &&
                                      o.ID_customer != customer.ID_customer)))
                {
                    throw new ArgumentException("Email đã được đăng ký");
                }
                if ((customer.username != null) &&
                    (db.Customers.Any(o => o.username == customer.username &&
                                      o.ID_customer != customer.ID_customer)))
                {
                    throw new ArgumentException("Tên tài khoản đã được sử dụng");
                }
            }
        }
        public static void ValidateCustomer(Customer customer)
        {
            // Validate fullname
            if (customer.fullname == null || customer.fullname == "")
            {
                throw new ArgumentException("Họ và tên là bắt buộc");
            }
            // Validate phone
            if ((customer.phone != null) && (!customer.phone.All(c => Char.IsDigit(c))))
            {
                throw new ArgumentException("Số điện thoại chỉ được chưa chữ số");
            }
            if ((customer.phone != null) &&
                (customer.phone.Length < 5 || customer.phone.Length > 11))
            {
                throw new ArgumentException("Độ dài số điện thoại không hợp lệ");
            }
            // Validate Student ID
            if ((customer.student_id != null) && (!customer.student_id.All(c => Char.IsDigit(c))))
            {
                throw new ArgumentException("Mã số sinh viên chỉ được chưa chữ số");
            }
            if ((customer.student_id != null) && (customer.student_id.Length != 9))
            {
                throw new ArgumentException("Mã số sinh viên phải có 9 kí tự");
            }
            // Validate username 
            if (customer.username == null)
            {
                throw new ArgumentException("Tên tài khoản là bắt buộc");
            }
            if ((customer.username != null) && (customer.username.Length < 3))
            {
                throw new ArgumentException("Tên tài khoản phải chứa ít nhất 3 kí tự");
            }
            if ((customer.username != null) && (customer.username.Length > 20))
            {
                throw new ArgumentException("Tên tài khoản chỉ chứa tối đa 20 kí tự");
            }
            if ((customer.username != null))
            {
                foreach (char c in customer.username)
                {
                    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
                    {
                        throw new ArgumentException("Tên tài khoản chỉ chứa các kí tự [a-zA-Z0-9]");
                    }
                }
            }
            if ((customer.password != null) && (customer.password.Length < 6))
            {
                throw new ArgumentException("Mật khẩu phải dài hơn 5 kí tự");
            }
            // Validate card
            if (customer.card_id == null)
            {
                throw new ArgumentNullException("Thẻ là bắt buộc");
            }
            // Validate email
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if ((customer.email != null) && (!regex.IsMatch(customer.email))){
                throw new ArgumentException("Email không hợp lệ");
            }

        }

        public static void ValidateEmployeeBeforeInsert(Employee employee)
        {
            ValidateEmployee(employee);
            // Validate password 
            if (employee.password == null)
            {
                throw new ArgumentException("Mật khẩu là bắt buộc");
            }
            if (employee.password.Length < 6)
            {
                throw new ArgumentException("Mật khẩu phải dài hơn 5 kí tự");
            }
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Validate if duplicate in DB
                if (db.Employees.Any(o => o.identity_card_number == employee.identity_card_number))
                {
                    throw new ArgumentException("Số CMND đã tồn tại");
                }
                if ((employee.username != null) &&
                    (db.Employees.Any(o => o.username == employee.username)))
                {
                    throw new ArgumentException("Tên tài khoản đã được sử dụng");
                }
            }
        }

        public static void ValidateEmployee(Employee employee)
        {
            // Validate fullname
            if (employee.fullname == null || employee.fullname == "")
            {
                throw new ArgumentException("Họ và tên là bắt buộc");
            }
            // Validate Student ID
            if (employee.identity_card_number == null)
            {
                throw new ArgumentException("Số CMND là bắt buộc");
            }
            if ((employee.identity_card_number != null) && (!employee.identity_card_number.All(c => Char.IsDigit(c))))
            {
                throw new ArgumentException("Số CMND chỉ được chứa chữ số");
            }
            if ((employee.identity_card_number != null) && (employee.identity_card_number.Length != 9))
            {
                throw new ArgumentException("Số CMND phải có 9 kí tự");
            }
            // Validate username 
            if (employee.username == null)
            {
                throw new ArgumentException("Tên tài khoản là bắt buộc");
            }
            if ((employee.username != null) && (employee.username.Length < 6))
            {
                throw new ArgumentException("Tên tài khoản phải dài hơn 5 kí tự");
            }
            // Validate role
            if (employee.role_id == null)
            {
                throw new ArgumentNullException("Vui lòng chọn chức vụ");
            }
        }

        public static void ValidateEmployeeBeforeUpdate(Employee employee)
        {
            ValidateEmployee(employee);
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Validate if duplicate in DB
                if (db.Employees.Any(o => o.identity_card_number == employee.identity_card_number &&
                                          o.ID_employee != employee.ID_employee))
                {
                    throw new ArgumentException("Số CMND đã được đăng ký");
                }
                if ((employee.username != null) &&
                    (db.Employees.Any(o => o.username == employee.username &&
                                      o.ID_employee != employee.ID_employee)))
                {
                    throw new ArgumentException("Tên tài khoản đã được sử dụng");
                }
            }
        }
    }
}
