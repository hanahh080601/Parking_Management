using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class AuthBLL
    {
        public Employee GetEmployeeByLogin(string username, string password)
        {
            // Early validate
            if (username == null || username == "") return null;
            if (password == null || password == "") return null;
            Employee result = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
           
                // Find by username
                result = db.Employees.Include("Role").Where(o => o.username == username).FirstOrDefault();
                // Return null if has no user  or wrong password
                if ((result == default(Employee)) || (!IsMatchingPassword(password, result.password)))
                {
                    result = null;
                }
            }
            return result;
        }
        public bool IsMatchingPassword(string input, string password)
        {
            //return input == password;
            return Encrypt(input) == password;
        }
        public string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            string result;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] hash = md5.ComputeHash(utf8.GetBytes(value));
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < hash.Length; j++)
                {
                    sb.Append(hash[j].ToString("X2"));
                }
                result = sb.ToString();
            }
            return result;
        }
        private AuthBLL() { }
        public static AuthBLL _Instance { get; set; }
        public static AuthBLL Instance 
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AuthBLL();
                }
                return _Instance;
            }
        }
    }
}
