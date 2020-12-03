using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class CategoryDAO
    {
        WebXeMotoDBContext db = null;

        public CategoryDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(Category entity)
        {
            entity.date_created = DateTime.Now;

            db.Categories.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public Category Detail(int id)
        {
            return db.Categories.Find(id);
        }

        public bool Update(Category entity)
        {
            try
            {
                var ca = db.Categories.Find(entity.id);

                ca.name = entity.name;

                ca.date_update = DateTime.Now;

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
                var ca = db.Categories.Find(id);

                db.Categories.Remove(ca);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Category> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<Category> model = db.Categories;
            if(!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<Category> ListOf()
        {
            return db.Categories.ToList();
        }
    }
}
