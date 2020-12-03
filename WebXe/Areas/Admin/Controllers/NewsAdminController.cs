using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class NewsAdminController : BaseController
    {
        // GET: Admin/NewsAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 4)
        {
            var stpAll = new NewsDAO();
            var model = stpAll.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/News/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/News/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(News stp)
        {
            if (ModelState.IsValid)
            {
                var dao = new NewsDAO();

                long id = dao.Insert(stp);
                if (id > 0)
                {
                    return RedirectToAction("Index", "NewsAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }
            return View();
        }

        // GET: Admin/News/Edit/5
        public ActionResult Edit(int id)
        {
            var stp = new NewsDAO().ViewDetail(id);
            return View(stp);
        }

        // POST: Admin/News/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(News stp)
        {
            if (ModelState.IsValid)
            {
                var dao = new NewsDAO();

                var result = dao.Update(stp);
                if (result)
                {
                    return RedirectToAction("Index", "NewsAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/News/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new NewsDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}
