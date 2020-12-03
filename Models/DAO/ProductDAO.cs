using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class ProductDAO
    {
        WebXeMotoDBContext db = null;

        public ProductDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(Product entity)
        {
            entity.date_created = DateTime.Now;

            db.Products.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public Product ViewDetail(int id)
        {
            return db.Products.Find(id);
        }

        public bool Update(Product entity)
        {
            try
            {
                var pr = db.Products.Find(entity.id);

                pr.name = entity.name;
                pr.price = entity.price;
                pr.sale = entity.sale;
                pr.number = entity.number;
                pr.information = entity.information;
                pr.imagemain = entity.imagemain;
                pr.imagechild1 = entity.imagechild1;
                pr.imagechild3 = entity.imagechild3;
                pr.imagechild2 = entity.imagechild2;
                pr.id_CarManufacturer = entity.id_CarManufacturer;
                pr.id_Category = entity.id_Category;
                pr.id_Color = entity.id_Color;
                pr.id_CylinderCapacity = entity.id_CylinderCapacity;
                pr.date_update = DateTime.Now;

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
                var pr = db.Products.Find(id);
                db.Products.Remove(pr);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Product> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<Product> model = db.Products;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<Product> ListOf()
        {
            return db.Products.ToList();
        }

        public List<Product> ListAll()
        {
            var list = db.Database.SqlQuery<Product>("Product_ListAll").ToList();
            return list;
        }

        public List<Product> ListNewPro()
        {
            var list = db.Database.SqlQuery<Product>("Product_ListNew").ToList();
            return list;
        }

        public IEnumerable<Product> ListByIDCar(int id)
        {
            IQueryable<Product> model = db.Products;
            model = model.Where(x => x.id_CarManufacturer == id);
            return model.OrderBy(x => x.id).ToList();
        }

        public IEnumerable<Product> ListByIDColor(int id)
        {
            IQueryable<Product> model = db.Products;
            model = model.Where(x => x.id_Color == id);
            return model.OrderBy(x => x.id).ToList();
        }

        public IEnumerable<Product> ListByIDCategory(int id)
        {
            IQueryable<Product> model = db.Products;
            model = model.Where(x => x.id_Category == id);
            return model.OrderBy(x => x.id).ToList();
        }

        public List<Product> ListNewAD()
        {
            var list = db.Database.SqlQuery<Product>("Product_ListNewAd").ToList();
            return list;
        }
    }
}
