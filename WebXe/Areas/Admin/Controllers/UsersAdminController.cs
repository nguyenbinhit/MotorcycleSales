using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class UsersAdminController : BaseController
    {
        // GET: Admin/UsersAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var iplAcc = new UserDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/Users/Details/5
        public ActionResult Details(int id)
        {
            var us = new UserDAO().ViewDetail(id);
            return View(us);
        }

        // GET: Admin/Users/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UserDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}
