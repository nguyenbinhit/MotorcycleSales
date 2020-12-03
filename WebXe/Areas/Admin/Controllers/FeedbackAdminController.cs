using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Areas.Admin.Data;

namespace WebXe.Areas.Admin.Controllers
{
    public class FeedbackAdminController : BaseController
    {
        // GET: Admin/FeedbackAdmin
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var iplAcc = new FeedbackDAO();
            var model = iplAcc.ListAllPage(page, pageSize);

            List<FeedbackAdminModel> listFB = new List<FeedbackAdminModel>();

            foreach (var item in model)
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

            return View(model);
        }

        // GET: Admin/Feedback/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Feedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Feedback/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Feedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Feedback/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Feedback/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new FeedbackDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}
