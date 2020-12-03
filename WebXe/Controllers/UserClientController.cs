using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Common;

namespace WebXe.Controllers
{
    public class UserClientController : Controller
    {
        // GET: UserClient/Edit/5
        public ActionResult Edit(int id)
        {
            var us = new UserDAO().ViewDetail(id);
            return View(us);
        }

        // POST: UserClient/Edit/5
        [HttpPost]
        public ActionResult Edit(User model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                if (!string.IsNullOrEmpty(model.password))
                {
                    var enMD5Pass = Encrytor.MD5Hash(model.password);
                    model.password = enMD5Pass;
                }
                var result = dao.Update(model);
                if (result)
                {
                    return RedirectToAction("Edit", "UserClient");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật thất bại");
                }
            }
            return View("Edit");
        }
    }
}
