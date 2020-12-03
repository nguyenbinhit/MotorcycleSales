using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;

namespace Models.DAO
{
    public class UserDAO
    {
        WebXeMotoDBContext db = null;

        public UserDAO()
        {
            db = new WebXeMotoDBContext();
        }

        public long Insert(User entity)
        {
            entity.date_created = DateTime.Now;

            db.Users.Add(entity);
            db.SaveChanges();

            return entity.id;
        }

        public long InsertForFacebook(User entity)
        {
            var user = db.Users.SingleOrDefault(x => x.name == entity.name);
            if(user == null) 
            {
                entity.date_created = DateTime.Now;

                db.Users.Add(entity);
                db.SaveChanges();

                return entity.id;
            }
            else
            {
                return user.id;
            }
            
        }

        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User entity)
        {
            try
            {
                var us = db.Users.Find(entity.id);

                us.name = entity.name;
                us.displayname = entity.displayname;
                if (!string.IsNullOrEmpty(entity.password))
                {
                    us.password = entity.password;
                }
                us.phone = entity.phone;
                us.address = entity.address;
                us.email = entity.email;
                us.thunbar = entity.thunbar;
                us.date_update = DateTime.Now;

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
                var us = db.Users.Find(id);
                db.Users.Remove(us);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<User> ListAllPage(string search, int page, int pageSize)
        {
            IQueryable<User> model = db.Users;
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.name.Contains(search));
            }

            return model.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }

        public List<User> ListAll()
        {
            return db.Database.SqlQuery<User>("User_ListAll").ToList();
        }

        public bool CheckUserName(string userName)
        {
            return db.Users.Count(x => x.name == userName) > 0;
        }

        public bool CheckEmail(string email)
        {
            return db.Users.Count(x => x.email == email) > 0;
        }

        public int Login(string accname, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.name == accname);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.password == password)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public User GetByID(string accname)
        {
            return db.Users.SingleOrDefault(x => x.name == accname);
        }
    }
}
