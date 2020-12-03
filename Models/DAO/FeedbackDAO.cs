using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class FeedbackDAO
    {
        WebXeMotoDBContext db = null;

        public FeedbackDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(Feedback entity)
        {
            entity.date_created = DateTime.Now;

            db.Feedbacks.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public bool Delete(int id)
        {
            try
            {
                var fb = db.Feedbacks.Find(id);
                db.Feedbacks.Remove(fb);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Feedback> ListAllPage(int page, int pageSize)
        {
            IQueryable<Feedback> model = db.Feedbacks;

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public IEnumerable<Feedback> ListNewFb(int id)
        {
            IQueryable<Feedback> model = db.Feedbacks;
            model = model.Where(x => x.id_Product == id);
            return model.OrderByDescending(x => x.id).ToList();

            //var list = db.Database.SqlQuery<Feedback>("Feedback_ListNew").ToList();
            //return list;
        }

        public List<Feedback> ListNewFbAdmin()
        {
            return db.Database.SqlQuery<Feedback>("FeedbackAdmin_List").ToList();
        }

        public List<Feedback> ListOf()
        {
            return db.Feedbacks.ToList();
        }
    }
}
