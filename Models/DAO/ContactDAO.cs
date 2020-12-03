using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class ContactDAO
    {
        WebXeMotoDBContext db = null;

        public ContactDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(Contact entity)
        {
            entity.date_created = DateTime.Now;

            db.Contacts.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public Contact Detail(int id)
        {
            return db.Contacts.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                var ct = db.Contacts.Find(id);

                db.Contacts.Remove(ct);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Contact> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<Contact> model = db.Contacts;
            if(!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<Contact> ListAll()
        {
            return db.Database.SqlQuery<Contact>("Contact_ListAll").ToList();
        }
    }
}
