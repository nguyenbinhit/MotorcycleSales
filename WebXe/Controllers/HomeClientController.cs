using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Controllers
{
    public class HomeClientController : Controller
    {
        // GET: HomeClient
        public ActionResult Index()
        {
            var iplProduct = new ProductDAO();
            var model = iplProduct.ListAll();
            ViewBag.Product = model;

            var iplCar = new CarManufacturerDAO();
            var carManufacturers = iplCar.ListAll();
            ViewBag.Car = carManufacturers;

            return View();
        }
    }
}
