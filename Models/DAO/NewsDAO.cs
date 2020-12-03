using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class NewsDAO
    {
        WebXeMotoDBContext db = null;

        public NewsDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(News entity)
        {
            entity.date_created = DateTime.Now;

            db.News.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public News ViewDetail(int id)
        {
            return db.News.Find(id);
        }

        public bool Update(News entity)
        {
            try
            {
                var ne = db.News.Find(entity.id);

                ne.name = entity.name;

                ne.content = entity.content;

                ne.thunbar = entity.thunbar;

                ne.date_update = DateTime.Now;

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
                var ne = db.News.Find(id);
                db.News.Remove(ne);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }

        public IEnumerable<News> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<News> model = db.News;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<News> ListAll()
        {
            return db.Database.SqlQuery<News>("News_ListAll").ToList();
        }

        public List<News> ListOf()
        {
            return db.News.ToList();
        }

        public List<News> ListNewAdmin()
        {
            return db.Database.SqlQuery<News>("NewsAdmin_ListAll").ToList();
        }
    }
}
