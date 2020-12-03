using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Areas.Admin.Data;
using WebXe.Common;

namespace WebXe.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: Admin/LoginAdmin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginAdminModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDAO();
                var result = dao.Login(model.AccName, Encrytor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var acc = dao.GetByID(model.AccName);
                    var accSession = new AccountLogin();
                    accSession.AccountName = acc.displayname;
                    accSession.AccountID = acc.id;

                    Session.Add(CommonConstants.ACCOUNT_SESSION, accSession);
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại !!!");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Sai mật khẩu. Vui lòng nhập lại !!!");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công !!!");
                }
            }

            return View("Index");
        }
    }
}