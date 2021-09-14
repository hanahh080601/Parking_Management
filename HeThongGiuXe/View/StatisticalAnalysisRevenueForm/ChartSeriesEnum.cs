using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongGiuXe.View
{
    class ChartSeriesEnum
    {
        private static string tOTAL_REVENUE = "Tổng doanh thu";
        private static string rEVENUE_PAYMENT_AT_PARKING = "Doanh thu tại quầy";
        private static string rEVENUE_PACKAGE = "Doanh thu các gói";

        public static string TOTAL_REVENUE { get => tOTAL_REVENUE; set => tOTAL_REVENUE = value; }
        public static string REVENUE_PAYMENT_AT_PARKING { get => rEVENUE_PAYMENT_AT_PARKING; set => rEVENUE_PAYMENT_AT_PARKING = value; }
        public static string REVENUE_PACKAGE { get => rEVENUE_PACKAGE; set => rEVENUE_PACKAGE = value; }
    }
}
