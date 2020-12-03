using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Areas.Admin.Data;

namespace WebXe.Areas.Admin.Controllers
{
    public class HomeAdminController : BaseController
    {
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            var listProduct = new ProductDAO().ListNewAD();
            var listPro = new ProductDAO().ListOf();
            ViewBag.Model = listPro.Count();
            
            List<ProductAdminModel> listP = new List<ProductAdminModel>();

            foreach (var item in listProduct)
            {
                var newP = new ProductAdminModel();
                newP.Id = item.id;
                newP.Name = item.name;
                newP.ManufacterId = item.id_CarManufacturer;
                newP.ManufacterName = item.CarManufacturer == null ? string.Empty : item.CarManufacturer.name;
                newP.Price = item.price;
                newP.Number = item.number;
                newP.Image = item.imagemain;
                listP.Add(newP);
            }
            ViewBag.Product = listP;

            var listAcc = new AccountDAO();
            var acc = listAcc.ListAll();
            ViewBag.Acc = acc;

            var listUsers = new UserDAO().ListAll();
            ViewBag.User = listUsers;

            var listNews = new NewsDAO().ListNewAdmin();
            ViewBag.News = listNews;

            var listContact = new ContactDAO().ListAll();
            ViewBag.Contact = listContact;

            var iplAcc = new FeedbackDAO();
            var fb = iplAcc.ListOf();
            List<FeedbackAdminModel> listFB = new List<FeedbackAdminModel>();
            foreach (var item in fb)
            {
                var newFb = new FeedbackAdminModel();
                newFb.ID = item.id;
                newFb.User_ID = item.id_User;
                newFb.User_Name = item.User == null ? string.Empty : item.User.displayname;
                newFb.Product_ID = item.id_Product;
                newFb.Product_Image = item.Product == null ? string.Empty : item.Product.imagemain;
                newFb.Star = item.star;
                newFb.Note = item.note;
                listFB.Add(newFb);
            }
            ViewBag.Feedback = listFB;

            var order = new OrderDAO().ListOf();
            ViewBag.Order = order.Count();
            ViewBag.Price = order.Sum(x => x.amount).ToString("N0");

            var car = new CarManufacturerDAO().ListOf();
            ViewBag.Car = car.Count();


            return View();
        }
    }
}