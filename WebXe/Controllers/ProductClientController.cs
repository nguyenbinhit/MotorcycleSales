using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Models;

namespace WebXe.Controllers
{
    public class ProductClientController : Controller
    {
        // GET: ProductClient
        public ActionResult Index(string search, int page = 1, int pageSize = 20)
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

            //var listAllPr = new ProductDAO().ListOf();
            //ViewBag.ALLPro = listAllPr;

            var iplAcc = new ProductDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: ProductClient/Details/5
        public ActionResult Details(int id)
        {
            var listHX = new CarManufacturerDAO().ListOf();
            ViewBag.HX = listHX;

            var listTL = new CategoryDAO().ListOf();
            ViewBag.TL = listTL;

            var listCL = new ColorDAO().ListOf();
            ViewBag.CL = listCL;

            var listAllPr = new ProductDAO().ListAll();
            ViewBag.Pr = listAllPr;

            var model = new FeedbackDAO().ListNewFb(id);
            List<FeedbackModel> listFb = new List<FeedbackModel>();
            foreach (var item in model)
            {
                var newFB = new FeedbackModel();
                newFB.ID = item.id;
                newFB.Product_ID = item.id_Product;
                newFB.User_ID = item.id_User;
                newFB.User_Name = item.User == null ? string.Empty : item.User.displayname;
                newFB.Star = item.star;
                newFB.Note = item.note;
                listFb.Add(newFB);
            }
            ViewBag.Feedback = listFb;

            var pr = new ProductDAO().ViewDetail(id);
            return View(pr);
        }

        [HttpPost]
        public ActionResult Create(FeedbackModel model)
        {
            if (ModelState.IsValid)
            {
                var login = new FeedbackDAO();

                var user = new Feedback();
                user.id_User = model.User_ID;
                user.id_Product = model.Product_ID;
                user.star = model.Star;
                user.note = model.Note;

                var result = login.Insert(user);
                if (result > 0)
                {
                    ViewBag.Success = "Đăng đánh giá bình luận thành công.";
                    return RedirectToAction("Index", "ProductClient");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng đánh giá bình luận không thành công !!!");
                }

            }
            var listHX = new CarManufacturerDAO().ListOf();
            ViewBag.HX = listHX;

            var listTL = new CategoryDAO().ListOf();
            ViewBag.TL = listTL;

            var listPK = new CylinderCapacityDAO().ListOf();
            ViewBag.PK = listPK;

            var listCL = new ColorDAO().ListOf();
            ViewBag.CL = listCL;

            var listAllPr = new ProductDAO().ListAll();
            ViewBag.Pr = listAllPr;

            var listNews = new NewsDAO().ListAll();
            ViewBag.New = listNews;

            var listNewPr = new ProductDAO().ListNewPro();
            ViewBag.Product = listNewPr;

            return View("Index");
        }
    }
}
