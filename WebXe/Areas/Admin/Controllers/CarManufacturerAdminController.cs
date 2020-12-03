using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class CarManufacturerAdminController : BaseController
    {
        // GET: Admin/CarManufacturerAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 5)
        {
            var iplAcc = new CarManufacturerDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/CarManufacturerAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CarManufacturerAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CarManufacturerAdmin/Create
        [HttpPost]
        public ActionResult Create(CarManufacturer cm)
        {
            if (ModelState.IsValid)
            {
                var dao = new CarManufacturerDAO();

                long id = dao.Insert(cm);
                if (id > 0)
                {
                    return RedirectToAction("Index", "CarManufacturerAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }
            return View();
        }

        // GET: Admin/CarManufacturerAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            var carManufacturer = new CarManufacturerDAO().Detail(id);
            return View(carManufacturer);
        }

        // POST: Admin/CarManufacturer/Edit/5
        [HttpPost]
        public ActionResult Edit(CarManufacturer carManufacturer)
        {
            if (ModelState.IsValid)
            {
                var dao = new CarManufacturerDAO();

                var result = dao.Update(carManufacturer);
                if (result)
                {
                    return RedirectToAction("Index", "CarManufacturerAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/CarManufacturerAdmin/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var idpro = new WebXeMotoDBContext().Products.Where(x => x.id_CarManufacturer == id);
            if(idpro == null)
            {
                new CarManufacturerDAO().Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Hãng xe đang chứa sản phẩm ! Bạn không thể xoá !";
                return RedirectToAction("Index");
            }   
        }
    }
}
