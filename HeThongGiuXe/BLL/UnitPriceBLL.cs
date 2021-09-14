using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeThongGiuXe.DAL;

namespace HeThongGiuXe.BLL
{
    class UnitPriceBLL
    {
        public DataTable GetDataTablePriceByDay(int day)
        {
            if (!(day >= 1 && day <= 7))
            {
                throw new ArgumentException("Day must be 1 -> 7");
            }
            // Prepare table
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Bắt đầu", typeof(TimeSpan)),
                new DataColumn("Kết thúc", typeof(TimeSpan)),
                new DataColumn("Giá", typeof(int))
            });
            using (DatabaseEntities db = new DatabaseEntities()) 
            {
                var result = db.Unit_Price.Where(o => o.day_in_week == day);
                foreach(Unit_Price item in result)
                {
                    DataRow row = table.NewRow();
                    row["Bắt đầu"] = item.start_time_in_day;
                    row["Kết thúc"] = item.end_time_in_day;
                    row["Giá"] = item.price;
                    table.Rows.Add(row);
                }
            }

            return table;
        }
        public void UpdateUnitPriceInDay(int day, List<Unit_Price> unitPrices)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                // Remove all price in this day
                db.Unit_Price.RemoveRange(db.Unit_Price.Where(o => o.day_in_week == day));
                db.SaveChanges();
                // Add new price
                db.Unit_Price.AddRange(unitPrices);
                db.SaveChanges();
            }
        }
        public void CreateUnitPrice(Unit_Price unitPrice)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Unit_Price.Add(unitPrice);
                db.SaveChanges();
            }
        }
        public DataTable GetDataTableByDate(Nullable<DateTime> dateTime = null)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Bắt đầu", typeof(DateTime)),
                new DataColumn("Kết thúc", typeof(DateTime)),
                new DataColumn("Giá", typeof(int)),
                new DataColumn("Ghi chú", typeof(string)),
            });
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var results = db.Unit_Price.Where(o
                    => dateTime == null ? 
                    o.day_in_week == null
                    :  (o.start_date <= dateTime
                    && o.end_date >= dateTime)
                    );
                foreach(Unit_Price unitPrice in results)
                {
                    DataRow row = table.NewRow();
                    row["ID"] = unitPrice.ID_unit_price;
                    row["Bắt đầu"] = unitPrice.start_date;
                    row["Kết thúc"] = unitPrice.end_date;
                    row["Giá"] = unitPrice.price;
                    row["Ghi chú"] = unitPrice.description;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public Unit_Price GetUnitPriceByID(int ID)
        {
            Unit_Price result = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                result = db.Unit_Price.Find(ID);
            }
            return result;
        }
        public void UpdateUnitPriceByID(int ID, Unit_Price unitPrice)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var result = db.Unit_Price.Find(ID);
                if (result != null)
                {
                    result.day_in_week = unitPrice.day_in_week;
                    result.description = unitPrice.description;
                    result.end_date = unitPrice.end_date;
                    result.price = unitPrice.price;
                    result.start_date = unitPrice.start_date;
                    db.SaveChanges();
                }
            }
        }
        public void DeleteUnitPriceByID(int ID)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var result = db.Unit_Price.Find(ID);
                if (result != null) db.Unit_Price.Remove(result);
                db.SaveChanges();
            }
        }
        // SIngleton
        private UnitPriceBLL() { }
        public static UnitPriceBLL _Instance { get; set; }
        public static UnitPriceBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new UnitPriceBLL();
                return _Instance;
            }
        }
    }
}
