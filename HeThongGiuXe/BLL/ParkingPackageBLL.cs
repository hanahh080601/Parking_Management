using HeThongGiuXe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongGiuXe.BLL
{
    class ParkingPackageBLL
    {
        private static ParkingPackageBLL _instance { get; set; }

        private ParkingPackageBLL()
        {
            
        }

        public static ParkingPackageBLL Instance()
        {
            if (_instance == null)
            {
                _instance = new ParkingPackageBLL();
            }
            return _instance;
        }

        public bool DeleteById(int packageId)
        {
            Parking_Package package = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                package = db.Parking_Package.Find(packageId);

                if (package == null) return false;

                db.Parking_Package.Remove(package);
                db.SaveChanges();

                return true;
            }
        }

        public bool CreatePackage(Parking_Package package)
        {
            try
            {
                Validator.ValidatePackageBeforeInsert(package);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Parking_Package.Add(package);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdatePackage(Parking_Package package)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                Parking_Package oldPackage = db.Parking_Package.Find(package.ID_package);

                if (oldPackage == null)
                {
                    return false;
                }

                oldPackage.name = package.name;
                oldPackage.description = package.description;
                oldPackage.price = package.price;
                oldPackage.duration = package.duration;
                oldPackage.visible = package.visible;

                db.SaveChanges();
                return true;
            }
        }

        public Parking_Package FindById(int id)
        {
            Parking_Package package = null;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                package = db.Parking_Package.Find(id);
            }
            return package;
        }

        public List<Parking_Package> FindAll(bool visible, string name)
        {
            List<Parking_Package> list = new List<Parking_Package>();
            using (DatabaseEntities db = new DatabaseEntities())
            {
                list = db.Parking_Package.Where(package =>
                        (package.visible == visible)
                        && (name == null ? true : package.name.ToLower().Contains(name))
                    )
                    .ToList();
            }

            return list;
        }

        // DEPRECATED - SHOULD NOT USE
        public DataTable getAllPackage()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                    new DataColumn(PackageDTableField.ID, typeof(int)),
                    new DataColumn(PackageDTableField.NAME, typeof(string)),
                    new DataColumn(PackageDTableField.PRICE, typeof(int)),
                    new DataColumn(PackageDTableField.DURATION, typeof(int)),
                    new DataColumn(PackageDTableField.DESCRIPTION, typeof(string))
            });

            using (DatabaseEntities db = new DatabaseEntities())
            {

                List<Parking_Package> list = db.Parking_Package
                                                .Where(package => package.visible == true)
                                                .ToList();

                foreach (Parking_Package package in list)
                {
                    DataRow dr = dt.NewRow();
                    dr[PackageDTableField.ID] = package.ID_package;
                    dr[PackageDTableField.NAME] = package.name;
                    dr[PackageDTableField.PRICE] = package.price;
                    dr[PackageDTableField.DURATION] = package.duration;
                    dr[PackageDTableField.DESCRIPTION] = package.description;

                    dt.Rows.Add(dr);
                }

            }

            return dt;
        }


    }

    class PackageDTableField
    {
        public static string ID = "ID";
        public static string NAME = "Tên";
        public static string PRICE = "Giá";
        public static string DURATION = "Thời lượng (ngày)";
        public static string DESCRIPTION = "Mô tả";
    }
}
