using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class OrdersDetailDAO
    {
        WebXeMotoDBContext db = null;

        public OrdersDetailDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public bool Insert(OrdersDetail entity)
        {
            try
            {
                db.OrdersDetails.Add(entity);
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
                string query = "DELETE FROM OrdersDetails WHERE id_Bill = " + id + " ";
                db.Database.ExecuteSqlCommand(query);

                //var order = db.OrdersDetails.Find(id);

                //db.OrdersDetails.Remove(model);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<OrdersDetail> Detail(int id)
        {
            IQueryable<OrdersDetail> model = db.OrdersDetails;
            model = model.Where(x => x.id_Bill == id);
            return model.OrderByDescending(x => x.id).ToList();
        }
    }
}
