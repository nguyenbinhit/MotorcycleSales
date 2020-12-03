using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class CylinderCapacityDAO
    {
        WebXeMotoDBContext db = null;

        public CylinderCapacityDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(CylinderCapacity entity)
        {
            entity.date_created = DateTime.Now;

            db.CylinderCapacities.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public CylinderCapacity Detail(int id)
        {
            return db.CylinderCapacities.Find(id);
        }

        public bool Update(CylinderCapacity entity)
        {
            try
            {
                var cc = db.CylinderCapacities.Find(entity.id);

                cc.name = entity.name;
                cc.date_update = DateTime.Now;

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
                var cc = db.CylinderCapacities.Find(id);
                db.CylinderCapacities.Remove(cc);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<CylinderCapacity> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<CylinderCapacity> model = db.CylinderCapacities;
            if(!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<CylinderCapacity> ListOf()
        {
            return db.CylinderCapacities.ToList();
        }
    }
}
