using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class StaticPageDAO
    {
        WebXeMotoDBContext db = null;

        public StaticPageDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(StaticPage entity)
        {
            entity.date_created = DateTime.Now;

            db.StaticPages.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public StaticPage ViewDetail(int id)
        {
            return db.StaticPages.Find(id);
        }

        public bool Update(StaticPage entity)
        {
            try
            {
                var sp = db.StaticPages.Find(entity.id);

                sp.name = entity.name;

                sp.content = entity.content;

                sp.thunbar = entity.thunbar;

                sp.date_update = DateTime.Now;

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
                var sp = db.StaticPages.Find(id);
                db.StaticPages.Remove(sp);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<StaticPage> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<StaticPage> model = db.StaticPages;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }


            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }
    }
}
