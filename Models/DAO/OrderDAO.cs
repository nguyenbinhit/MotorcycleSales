using Models.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class OrderDAO
    {
        WebXeMotoDBContext db = null;

        public OrderDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(Order entity)
        {
            db.Orders.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public bool Update(Order entity)
        {
            try
            {
                var order = db.Orders.Find(entity.id);
                order.status = 1;

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
                var order = db.Orders.Find(id);

                db.Orders.Remove(order);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Order> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<Order> model = db.Orders;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.note.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<Order> ListOf()
        {
            return db.Orders.ToList();
        }

        public IEnumerable<Order> Detail(int id)
        {
            IQueryable<Order> model = db.Orders;
            model = model.Where(x => x.id == id);
            return model.OrderByDescending(x => x.id).ToList();
        }

        public IEnumerable<Order> OrderByUser(int id, int page, int pageSize)
        {
            IQueryable<Order> model = db.Orders;
            model = model.Where(x => x.id_User == id);

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }
    }
}
