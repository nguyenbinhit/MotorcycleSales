using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class StaticPageAdminController : BaseController
    {
        // GET: Admin/StaticPageAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 4)
        {
            var stpAll = new StaticPageDAO();
            var model = stpAll.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/StaticPage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/StaticPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/StaticPage/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(StaticPage stp)
        {
            if (ModelState.IsValid)
            {
                var dao = new StaticPageDAO();

                long id = dao.Insert(stp);
                if (id > 0)
                {
                    return RedirectToAction("Index", "StaticPageAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }
            return View();
        }

        // GET: Admin/StaticPage/Edit/5
        public ActionResult Edit(int id)
        {
            var stp = new StaticPageDAO().ViewDetail(id);
            return View(stp);
        }

        // POST: Admin/StaticPage/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(StaticPage stp)
        {
            if (ModelState.IsValid)
            {
                var dao = new StaticPageDAO();

                var result = dao.Update(stp);
                if (result)
                {
                    return RedirectToAction("Index", "StaticPageAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/StaticPage/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new StaticPageDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}
