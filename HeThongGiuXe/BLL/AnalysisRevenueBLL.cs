using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class AnalysisRevenueMonthResult
    {
        public int MONTH { get; set; }
        public int NUM_VEHICLES { get; set; }
        public int SUM { get; set; }

        public int REVENUE_PACKAGE { get; set; }
        public int REVENUE_PAYMENT_AT_PARKING { get; set; }
    }

    class AnalysDTableColumnEnum
    {
        public static string MONTH = "Tháng";
        public static string NUM_VEHICLES = "Số lượng xe ra/vào";
        public static string REVENUE_PACKAGE = "Tiền thu các gói";
        public static string REVENUE_PAYMENT_AT_PARKING = "Tiền thu tại quầy";
        public static string REVENUE = "Doanh thu";
    }
    class AnalysisRevenueBLL
    {
        // Singleton
        public static AnalysisRevenueBLL _Instance { get; set; }

        public static AnalysisRevenueBLL Instance()
        {
            if (_Instance == null)
            {
                _Instance = new AnalysisRevenueBLL();
            }

            return _Instance;
        }

        private AnalysisRevenueBLL()
        {

        }

        public DataTable GetDataTableRevenue(int year)
        {
            /**
             * Revenue = ParkingHistory.price where paid_at = (month, year) + 
             *              Payment.price where check_out_at = (month,year)
             */
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn(AnalysDTableColumnEnum.MONTH, typeof(string)),
                new DataColumn(AnalysDTableColumnEnum.NUM_VEHICLES, typeof(int)),
                new DataColumn(AnalysDTableColumnEnum.REVENUE_PACKAGE, typeof(int)),
                new DataColumn(AnalysDTableColumnEnum.REVENUE_PAYMENT_AT_PARKING, typeof(int)),
                new DataColumn(AnalysDTableColumnEnum.REVENUE, typeof(string))
            });

            
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // doanh thu cac thang tu viec thu tien truc tiep
                List<AnalysisRevenueMonthResult> result1 = db.Parking_History.Where(item => 
                        (item.check_out_at.HasValue ? item.check_out_at.Value.Year == year : false))
                    .GroupBy(item => item.check_out_at.Value.Month)
                    .Select(
                        g => new AnalysisRevenueMonthResult
                        {
                            MONTH = g.Key,
                            SUM = g.Sum(item => item.price),
                            NUM_VEHICLES = g.Count(),
                            REVENUE_PAYMENT_AT_PARKING = g.Sum(item => item.price)
                        }
                    ).OrderBy(item => item.MONTH).ToList();

                // Doanh thu cac thang tu viec dang ki tra truoc thong qua cac goi gui xe
                List<AnalysisRevenueMonthResult> result2 = db.Payments
                    .Where(payment => (payment.paid_at.HasValue ? payment.paid_at.Value.Year == year : false))
                    .GroupBy(payment => payment.paid_at.Value.Month)
                    .Select(g => new AnalysisRevenueMonthResult
                    {
                        MONTH = g.Key,
                        SUM = g.Sum(payment => payment.price),
                        NUM_VEHICLES = 0,
                        REVENUE_PACKAGE = g.Sum(payment => payment.price)
                    }).ToList();

                // Tong doanh thu hang thang
                Dictionary<int, AnalysisRevenueMonthResult> dict = new Dictionary<int, AnalysisRevenueMonthResult>();

                foreach (AnalysisRevenueMonthResult item in result1)
                {
                    if (dict.ContainsKey(item.MONTH))
                    {
                        dict[item.MONTH].SUM += item.SUM;
                    }
                    else
                    {
                        dict[item.MONTH] = item;
                    }
                }

                foreach (AnalysisRevenueMonthResult item in result2)
                {
                    if (dict.ContainsKey(item.MONTH))
                    {
                        dict[item.MONTH].SUM += item.SUM;
                        dict[item.MONTH].REVENUE_PACKAGE += item.REVENUE_PACKAGE;
                    } else
                    {
                        dict[item.MONTH] = item;
                    }
                }

                List<AnalysisRevenueMonthResult> list = dict.Values.ToList();

                foreach (AnalysisRevenueMonthResult item in list)
                {
                    DataRow row = dt.NewRow();
                    row[AnalysDTableColumnEnum.MONTH] = item.MONTH;
                    row[AnalysDTableColumnEnum.NUM_VEHICLES] = item.NUM_VEHICLES;
                    row[AnalysDTableColumnEnum.REVENUE] = item.SUM;
                    row[AnalysDTableColumnEnum.REVENUE_PACKAGE] = item.REVENUE_PACKAGE;
                    row[AnalysDTableColumnEnum.REVENUE_PAYMENT_AT_PARKING] = item.REVENUE_PAYMENT_AT_PARKING;

                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

        public DataTable GetDataTableRevenue(int month, int year)
        {
            DataTable dt = CreateDTableRevenueEachDay();

            using (DatabaseEntities db = new DatabaseEntities())
            {
                // doanh thu cac thang tu viec thu tien truc tiep
                List<AnalysisRevenueDayResult> result1 = db.Parking_History.Where(item =>
                        (item.check_out_at.HasValue ? (item.check_out_at.Value.Year == year)
                                                    && (item.check_out_at.Value.Month == month) : false))
                    .GroupBy(item => item.check_out_at.Value.Day)
                    .Select(
                        g => new AnalysisRevenueDayResult
                        {
                            DAY = g.Key,
                            SUM = g.Sum(item => item.price),
                            NUM_VEHICLES = g.Count(),
                            REVENUE_PAYMENT_AT_PARKING = g.Sum(item => item.price)
                        }
                    ).OrderBy(item => item.DAY).ToList();


                // Doanh thu cac thang tu viec dang ki tra truoc thong qua cac goi gui xe
                List<AnalysisRevenueDayResult> result2 = db.Payments
                    .Where(payment => (payment.paid_at.HasValue ? (payment.paid_at.Value.Year == year)
                                                                && (payment.paid_at.Value.Month == month) : false))
                    .GroupBy(payment => payment.paid_at.Value.Day)
                    .Select(g => new AnalysisRevenueDayResult
                    {
                        DAY = g.Key,
                        SUM = g.Sum(payment => payment.price),
                        NUM_VEHICLES = 0,
                        REVENUE_PACKAGE = g.Sum(payment => payment.price)
                    }).ToList();

                // Tong doanh thu hang thang
                Dictionary<int, AnalysisRevenueDayResult> dict = new Dictionary<int, AnalysisRevenueDayResult>();

                foreach (AnalysisRevenueDayResult item in result1)
                {
                    if (dict.ContainsKey(item.DAY))
                    {
                        dict[item.DAY].SUM += item.SUM;
                    }
                    else
                    {
                        dict[item.DAY] = item;
                    }
                }

                foreach (AnalysisRevenueDayResult item in result2)
                {
                    if (dict.ContainsKey(item.DAY))
                    {
                        dict[item.DAY].SUM += item.SUM;
                        dict[item.DAY].REVENUE_PACKAGE += item.REVENUE_PACKAGE;
                    }
                    else
                    {
                        dict[item.DAY] = item;
                    }
                }

                List<AnalysisRevenueDayResult> list = dict.Values.ToList();

                foreach (AnalysisRevenueDayResult item in list)
                {
                    DataRow row = dt.NewRow();
                    row[RevenueEachDayDTableField.DAY] = item.DAY;
                    row[RevenueEachDayDTableField.NUM_VEHICLES] = item.NUM_VEHICLES;
                    row[RevenueEachDayDTableField.REVENUE] = item.SUM;
                    row[RevenueEachDayDTableField.REVENUE_PACKAGE] = item.REVENUE_PACKAGE;
                    row[RevenueEachDayDTableField.REVENUE_PAYMENT_AT_PARKING] = item.REVENUE_PAYMENT_AT_PARKING;

                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

        public DataTable CreateDTableRevenueEachDay()
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn(RevenueEachDayDTableField.DAY, typeof(string)),
                new DataColumn(RevenueEachDayDTableField.NUM_VEHICLES, typeof(int)),
                new DataColumn(RevenueEachDayDTableField.REVENUE_PACKAGE, typeof(int)),
                new DataColumn(RevenueEachDayDTableField.REVENUE_PAYMENT_AT_PARKING, typeof(int)),
                new DataColumn(RevenueEachDayDTableField.REVENUE, typeof(string))
            });

            return dt;
        }

    }

    class RevenueEachDayDTableField
    {
        public static string DAY = "Ngày";
        public static string NUM_VEHICLES = "Số lượng xe ra/vào";
        public static string REVENUE_PACKAGE = "Tiền thu các gói";
        public static string REVENUE_PAYMENT_AT_PARKING = "Tiền thu tại quầy";
        public static string REVENUE = "Doanh thu";
    }

    class AnalysisRevenueDayResult
    {
        public int DAY { get; set; }
        public int NUM_VEHICLES { get; set; }
        public int SUM { get; set; }

        public int REVENUE_PACKAGE { get; set; }
        public int REVENUE_PAYMENT_AT_PARKING { get; set; }
    }
}
