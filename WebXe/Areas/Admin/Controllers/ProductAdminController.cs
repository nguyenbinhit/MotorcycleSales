using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Areas.Admin.Controllers
{
    public class ProductAdminController : BaseController
    {
        // GET: Admin/ProductAdmin
        public ActionResult Index(string search, int page = 1, int pageSize = 5)
        {
            var iplAcc = new ProductDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            var pr = new ProductDAO().ViewDetail(id);
            return View(pr);
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            CarManufacturerDAO hx = new CarManufacturerDAO();
            var hxList = hx.ListOf();

            CategoryDAO lx = new CategoryDAO();
            var lxList = lx.ListOf();

            CylinderCapacityDAO dtxl = new CylinderCapacityDAO();
            var dtxlList = dtxl.ListOf();

            ColorDAO mx = new ColorDAO();
            var mxList = mx.ListOf();

            ViewBag.HX = hxList;
            ViewBag.LX = lxList;
            ViewBag.DTXL = dtxlList;
            ViewBag.MX = mxList;

            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDAO();

                long id = dao.Insert(product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "ProductAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }

            return View();
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            var sp = new ProductDAO().ViewDetail(id);

            CarManufacturerDAO hx = new CarManufacturerDAO();
            var hxList = hx.ListOf();

            CategoryDAO lx = new CategoryDAO();
            var lxList = lx.ListOf();

            CylinderCapacityDAO dtxl = new CylinderCapacityDAO();
            var dtxlList = dtxl.ListOf();

            ColorDAO mx = new ColorDAO();
            var mxList = mx.ListOf();

            ViewBag.HX = hxList;
            ViewBag.LX = lxList;
            ViewBag.DTXL = dtxlList;
            ViewBag.MX = mxList;

            return View(sp);
        }

        // POST: Admin/Product/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(Product sp)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDAO();

                var result = dao.Update(sp);
                if (result)
                {
                    return RedirectToAction("Index", "ProductAdmin");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/Product/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var idorder = new WebXeMotoDBContext().OrdersDetails.Where(x => x.id_Product == id);
            if(idorder == null)
            {
                new ProductDAO().Delete(id);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Sản phẩm đang có trong đơn hàng. Bạn không thể xoá !!!";
                return RedirectToAction("Index");
            }
            
        }
    }
}
