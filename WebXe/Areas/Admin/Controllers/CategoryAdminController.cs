using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class CategoryAdminController : BaseController
    {
        // GET: Admin/CategoryAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var iplAcc = new CategoryDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/CategoryAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CategoryAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CategoryAdmin/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryDAO();

                long id = dao.Insert(category);
                if (id > 0)
                {
                    return RedirectToAction("Index", "CategoryAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }
            return View();
        }

        // GET: Admin/CategoryAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            var category = new CategoryDAO().Detail(id);
            return View(category);
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryDAO();

                var result = dao.Update(category);
                if (result)
                {
                    return RedirectToAction("Index", "CategoryAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/Category/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var idpro = new WebXeMotoDBContext().Products.Where(x => x.id_CarManufacturer == id);
            if (idpro == null)
            {
                new CategoryDAO().Delete(id);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Thể loại xe đang chứa sản phẩm ! Bạn không thể xoá !";
                return RedirectToAction("Index");
            }
        }
    }
}
