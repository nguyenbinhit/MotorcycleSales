using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class ColorAdminController : BaseController
    {
        // GET: Admin/ColorAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var iplAcc = new ColorDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/Color/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Color/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Color/Create
        [HttpPost]
        public ActionResult Create(Color cl)
        {
            if (ModelState.IsValid)
            {
                var dao = new ColorDAO();

                long id = dao.Insert(cl);
                if (id > 0)
                {
                    return RedirectToAction("Index", "ColorAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }
            return View();
        }

        // GET: Admin/Color/Edit/5
        public ActionResult Edit(int id)
        {
            var cl = new ColorDAO().Detail(id);
            return View(cl);
        }

        // POST: Admin/Color/Edit/5
        [HttpPost]
        public ActionResult Edit(Color cl)
        {
            if (ModelState.IsValid)
            {
                var dao = new ColorDAO();

                var result = dao.Update(cl);
                if (result)
                {
                    return RedirectToAction("Index", "ColorAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/Color/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var idpro = new WebXeMotoDBContext().Products.Where(x => x.id_CarManufacturer == id);
            if (idpro == null)
            {
                new ColorDAO().Delete(id);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Màu xe đang chứa sản phẩm ! Bạn không thể xoá !";
                return RedirectToAction("Index");
            }
        }
    }
}
