using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.Utils
{
    class Session
    {
        private static Employee User;
        public static void SetUser(Employee user)
        {
            User = user;
        } 
        public static Employee GetCurrentUser()
        {
            return User;
        }
        public static void RemoveCurrentUser()
        {
            User = null;
        }
        public static bool HasUser()
        {
            return User != null;
        }
    }
}
