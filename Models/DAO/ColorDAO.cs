using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class ColorDAO
    {
        WebXeMotoDBContext db = null;

        public ColorDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(Color entity)
        {
            entity.date_created = DateTime.Now;

            db.Colors.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public Color Detail(int id)
        {
            return db.Colors.Find(id);
        }

        public bool Update(Color entity)
        {
            try
            {
                var cl = db.Colors.Find(entity.id);

                cl.name = entity.name;
                cl.date_update = DateTime.Now;

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
                var cl = db.Colors.Find(id);
                db.Colors.Remove(cl);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Color> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<Color> model = db.Colors;
            if(!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<Color> ListOf()
        {
            return db.Colors.ToList();
        }
    }
}
