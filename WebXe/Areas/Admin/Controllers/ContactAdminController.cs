using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class ContactAdminController : BaseController
    {
        // GET: Admin/ContactAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 5)
        {
            var iplAcc = new ContactDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/Contact/Details/5
        public ActionResult Details(int id)
        {
            var ct = new ContactDAO().Detail(id);

            return View(ct);
        }

        // GET: Admin/Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contact/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new ContactDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}
