using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Common;

namespace WebXe.Areas.Admin.Controllers
{
    public class ADNVController : BaseController
    {
        // GET: Admin/ADNV
        public ActionResult Index(string search, int page = 1, int pageSize = 10)
        {
            var iplAcc = new AccountDAO();
            var model = iplAcc.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: Admin/ADNV/Details/5
        public ActionResult Details(int id)
        {
            var acc = new AccountDAO().Detail(id);
            return View(acc);
        }

        // GET: Admin/ADNV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ADNV/Create
        [HttpPost]
        public ActionResult Create(Account acc)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDAO();
                var enMD5Pass = Encrytor.MD5Hash(acc.password);
                acc.password = enMD5Pass;

                long id = dao.Insert(acc);
                if (id > 0)
                {
                    return RedirectToAction("Index", "ADNV");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới thất bại");
                }
            }
            return View();
        }

        // GET: Admin/ADNV/Edit/5
        public ActionResult Edit(int id)
        {
            var acc = new AccountDAO().Detail(id);
            return View(acc);
        }

        // POST: Admin/ADNV/Edit/5
        [HttpPost]
        public ActionResult Edit(Account acc)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDAO();
                if (!string.IsNullOrEmpty(acc.password))
                {
                    var enMD5Pass = Encrytor.MD5Hash(acc.password);
                    acc.password = enMD5Pass;
                }
                var result = dao.Update(acc);
                if (result)
                {
                    return RedirectToAction("Index", "ADNV");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Index");
        }

        // GET: Admin/ADNV/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new AccountDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}
