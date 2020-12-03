using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class CylinderCapacityAdminController : BaseController
    {
        // GET: Admin/CylinderCapacityAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var iplAcc = new CylinderCapacityDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/CylinderCapacity/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CylinderCapacity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CylinderCapacity/Create
        [HttpPost]
        public ActionResult Create(CylinderCapacity cylinderCapacity)
        {
            if (ModelState.IsValid)
            {
                var dao = new CylinderCapacityDAO();

                long id = dao.Insert(cylinderCapacity);
                if (id > 0)
                {
                    return RedirectToAction("Index", "CylinderCapacityAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }
            return View();
        }

        // GET: Admin/CylinderCapacity/Edit/5
        public ActionResult Edit(int id)
        {
            var cl = new CylinderCapacityDAO().Detail(id);
            return View(cl);
        }

        // POST: Admin/CylinderCapacity/Edit/5
        [HttpPost]
        public ActionResult Edit(CylinderCapacity cylinderCapacity)
        {
            if (ModelState.IsValid)
            {
                var dao = new CylinderCapacityDAO();

                var result = dao.Update(cylinderCapacity);
                if (result)
                {
                    return RedirectToAction("Index", "CylinderCapacityAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/CylinderCapacity/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var idpro = new WebXeMotoDBContext().Products.Where(x => x.id_CarManufacturer == id);
            if (idpro == null)
            {
                new CylinderCapacityDAO().Delete(id);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Dung tích xi lanh xe đang chứa sản phẩm ! Bạn không thể xoá !";
                return RedirectToAction("Index");
            }
        }
    }
}
