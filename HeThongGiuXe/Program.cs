using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.View;

namespace HeThongGiuXe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new AnalysisRevenueForm());
            //Application.Run(new PaymentManagementForm());
            //Application.Run(new ParkingPackageForm());
        }
    }
}
