using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Controllers
{
    public class ContactClientController : Controller
    {
        public ActionResult Create()
        {
            var listNews = new NewsDAO().ListAll();
            ViewBag.New = listNews;

            return View();
        }

        // POST: ContactClient/Create
        [HttpPost]
        public ActionResult Create(Contact lh)
        {
            if (ModelState.IsValid)
            {
                var dao = new ContactDAO();

                long id = dao.Insert(lh);
                if (id > 0)
                {
                    return RedirectToAction("Index", "HomeClient");
                }
                else
                {
                    ModelState.AddModelError("", "Liên hệ thất bại");
                }
            }

            var listNews = new NewsDAO().ListAll();
            ViewBag.New = listNews;

            return View();
        }
    }
}
