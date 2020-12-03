using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class AccountDAO
    {
        WebXeMotoDBContext db = null;

        public AccountDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(Account entity)
        {
            entity.date_created = DateTime.Now;

            db.Accounts.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public Account Detail(int id)
        {
            return db.Accounts.Find(id);
        }

        public bool Update(Account entity)
        {
            try
            {
                var acc = db.Accounts.Find(entity.id);

                if(string.IsNullOrEmpty(entity.name))
                {
                    acc.name = entity.name;
                }

                acc.displayname = entity.displayname;

                if(string.IsNullOrEmpty(entity.password))
                {
                    acc.password = entity.password;
                }

                acc.phone = entity.phone;

                acc.address = entity.address;

                acc.email = entity.email;

                acc.thunbar = entity.thunbar;

                acc.type_account = entity.type_account;

                acc.date_update = DateTime.Now;

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
                var acc = db.Accounts.Find(id);

                db.Accounts.Remove(acc);

                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Login(string accname, string password)
        {
            var result = db.Accounts.SingleOrDefault(x => x.name == accname);
            if(result == null)
            {
                return 0;
            }
            else
            {
                if(result.password == password)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public Account GetByID(string accname)
        {
            return db.Accounts.SingleOrDefault(x => x.name == accname);
        }

        public List<Account> ListAll()
        {
            return db.Database.SqlQuery<Account>("Account_ListAll").ToList();
        }

        public IEnumerable<Account> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<Account> model = db.Accounts;
            if(!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search) || x.displayname.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }
    }
}
