using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class EmployeeBLL
    {
        // Singleton
        private EmployeeBLL() { }
        public static EmployeeBLL _Instance { get; set; }
        public static EmployeeBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new EmployeeBLL();
                return _Instance;
            }
        }

        public void CreateEmployee(Employee employee)
        {
            Validator.ValidateEmployeeBeforeInsert(employee);
            employee.password = AuthBLL.Instance.Encrypt(employee.password);
            using (DatabaseEntities db = new DatabaseEntities())
            {
                employee.created_at = DateTime.Now;
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public List<Employee> GetEmployees(
            string fullname = null,
            string IDcardnumb = null,
            string username = null
            )
        {
            List<Employee> results = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                results = db.Employees.Where(o
                    => (fullname == null ? true : o.fullname.Contains(fullname))
                    && (IDcardnumb == null ? true : (o.identity_card_number == null ? false : o.identity_card_number.Contains(IDcardnumb)))
                    && (username == null ? true : (o.username == null ? false : o.username.Contains(username)))
                ).ToList();
            }
            return results;
        }

        public DataTable GetDataTableEmployees(
            string fullname = null,
            string IDcardnumb = null
            //string username = null
            )
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Họ và tên", typeof(string)),
                new DataColumn("Số CMND", typeof(string)),
                new DataColumn("Giới tính", typeof(bool)),
                new DataColumn("Ngày sinh", typeof(DateTime)),
                new DataColumn("Tên tài khoản", typeof(string)),
                new DataColumn("Chức vụ", typeof(string)),
                new DataColumn("Tạo lúc", typeof(DateTime)),
                new DataColumn("Cập nhật lúc", typeof(DateTime)),
            });
            List<Employee> results = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                results = db.Employees.Where(o
                    => (fullname == null ? true : o.fullname.ToLower().Contains(fullname.ToLower()))
                    && (IDcardnumb == null ? true : (o.identity_card_number == null ? false : o.identity_card_number.Contains(IDcardnumb)))
                    //&& (username == null ? true : (o.username == null ? false : o.username.Contains(username)))
                ).ToList();

                foreach(Employee employee in results)
                {
                    DataRow row = table.NewRow();
                    row["ID"] = employee.ID_employee;
                    row["Họ và tên"] = employee.fullname;
                    row["Số CMND"] = employee.identity_card_number;
                    row["Giới tính"] = employee.gender;
                    row["Ngày sinh"] = employee.birthday;
                    row["Tên tài khoản"] = employee.username;
                    row["Chức vụ"] = employee.Role.description;
                    row["Tạo lúc"] = employee.created_at;
                    if (employee.updated_at != null)
                    {
                        row["Cập nhật lúc"] = employee.updated_at;

                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }

        public Employee GetEmployeeByID(int ID)
        {
            //Employee result = null;
            //using (DatabaseEntities db = new DatabaseEntities())
            //{
            //    result = db.Employees.Include("Role").Where(o => o.ID_employee == ID).FirstOrDefault();
            //}
            //return result == default(Employee) ? null : result;
            Employee result = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Employees.Find(ID);
            }
            return result;
        }

        public void DeleteEmployee(int ID)
        {
            Employee employee = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                employee = db.Employees.Find(ID);
                if (employee != null) db.Employees.Remove(employee);
                db.SaveChanges();
            }
            if (employee == null) throw new Exception("Tài khoản không tồn tại");
        }

        public void UpdateEmployee(Employee employee)
        {
            Validator.ValidateEmployeeBeforeUpdate(employee);
            Employee target = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                target = db.Employees.Find(employee.ID_employee);
                if (target != null)
                {
                    target.fullname = employee.fullname;
                    target.birthday = employee.birthday;
                    target.identity_card_number = employee.identity_card_number;
                    target.password = employee.password == null 
                        ? target.password
                        : AuthBLL.Instance.Encrypt(employee.password);
                    target.gender = employee.gender;
                    target.username = employee.username;
                    target.updated_at = DateTime.Now;
                    target.role_id = employee.role_id;
                    db.SaveChanges();
                }
            }
            if (target == null)
            {
                throw new Exception("Tài khoản không tồn tại");
            }
        }

        public Employee GetEmployeeByIDNumber(string IDnumber)
        {
            Employee result;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Employees.Where(o => o.identity_card_number == IDnumber)
                    .FirstOrDefault();
            }
            return (result == default(Employee)) ? null : result;
        }
    }
}
