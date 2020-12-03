using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Controllers
{
    public class CarManufacturerClientController : Controller
    {
        // GET: CarManufacturerClient
        public ActionResult Index(int id)
        {
            var listHX = new CarManufacturerDAO().ListOf();
            ViewBag.HX = listHX;

            var listTL = new CategoryDAO().ListOf();
            ViewBag.TL = listTL;

            var listPK = new CylinderCapacityDAO().ListOf();
            ViewBag.PK = listPK;

            var listCL = new ColorDAO().ListOf();
            ViewBag.CL = listCL;

            var listNews = new NewsDAO().ListAll();
            ViewBag.New = listNews;

            var listNewPr = new ProductDAO().ListNewPro();
            ViewBag.Product = listNewPr;

            var listAllPr = new ProductDAO().ListByIDCar(id);
            ViewBag.ALLPro = listAllPr;

            return View();
        }
    }
}