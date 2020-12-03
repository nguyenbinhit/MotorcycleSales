using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class CarManufacturerDAO
    {
        WebXeMotoDBContext db = null;

        public CarManufacturerDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(CarManufacturer entity)
        {
            entity.date_created = DateTime.Now;

            db.CarManufacturers.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public CarManufacturer Detail(int id)
        {
            return db.CarManufacturers.Find(id);
        }

        public bool Update(CarManufacturer entity)
        {
            try
            {
                var cm = db.CarManufacturers.Find(entity.id);

                cm.name = entity.name;

                cm.thunbar = entity.thunbar;

                cm.date_update = DateTime.Now;

                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var cm = db.CarManufacturers.Find(id);
                db.CarManufacturers.Remove(cm);
                db.SaveChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public List<CarManufacturer> ListAll()
        {
            return db.Database.SqlQuery<CarManufacturer>("CarManufacturer_ListAll").ToList();
        }

        public IEnumerable<CarManufacturer> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<CarManufacturer> model = db.CarManufacturers;
            if(!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<CarManufacturer> ListOf()
        {
            return db.CarManufacturers.ToList();
        }
    }
}
