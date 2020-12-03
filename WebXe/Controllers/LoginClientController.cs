using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Common;
using WebXe.Models;
using Facebook;
using System.Configuration;

namespace WebXe.Controllers
{
    public class LoginClientController : Controller
    {
        // Fb
        private Uri RedirectUri
        {
            get
            {
                var uriBuilder = new UriBuilder(Request.Url);
                uriBuilder.Query = null;
                uriBuilder.Fragment = null;
                uriBuilder.Path = Url.Action("FacebookCallback");

                return uriBuilder.Uri;
            }
        }


        // GET: LoginClient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return RedirectToAction("Index", "HomeClient");
        }


        [HttpPost]
        public ActionResult Login(MyViewModel model)
        {
            var mode = model.Login;

            if(ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.Login(mode.UserName, Encrytor.MD5Hash(mode.PassWord));
                if (result == 1)
                {
                    var us = dao.GetByID(mode.UserName);
                    var usSession = new UserLogin();
                    usSession.UserName = us.displayname;
                    usSession.UserID = us.id;
                    usSession.UserEmail = us.email;
                    usSession.UserPhone = us.phone;
                    usSession.UserAddress = us.address;
                    usSession.UserImage = us.thunbar;

                    Session.Add(CommonConstants.USER_SESSION, usSession);
                    return RedirectToAction("Index", "HomeClient");
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

        //Login Facebook
        public ActionResult LoginFacebook()
        {
            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = ConfigurationManager.AppSettings["FbAppId"],
                client_secret = ConfigurationManager.AppSettings["FbAppSecret"],
                redirect_uri = RedirectUri.AbsoluteUri,
                response_type = "code",
                scope = "email",
            });

            return Redirect(loginUrl.AbsoluteUri);
        }

        public ActionResult FacebookCallback(string code)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Post("oauth/access_token", new
            {
                client_id = ConfigurationManager.AppSettings["FbAppId"],
                client_secret = ConfigurationManager.AppSettings["FbAppSecret"],
                redirect_uri = RedirectUri.AbsoluteUri,
                code = code
            });

            var accessToken = result.access_token;
            if (!string.IsNullOrEmpty(accessToken))
            {
                fb.AccessToken = accessToken;
                //Get the user's information, like email, first name, middle name etc
                dynamic me = fb.Get("me?fields=first_name, middle_name, last_name, id, email");
                string email = me.email;
                string userName = me.email;
                string fistname = me.first_name;
                string middlename = me.middle_name;
                string lastname = me.last_name;

                var user = new User();
                user.email = email;
                user.name = email;
                user.displayname = fistname + " " + middlename + " " + lastname;
                user.date_created = DateTime.Now;

                var resultInsertFb = new UserDAO().InsertForFacebook(user);
                if (resultInsertFb > 0)
                {
                    var usSession = new UserLogin();
                    usSession.UserName = user.displayname;
                    usSession.UserID = user.id;
                    usSession.UserEmail = user.email;

                    Session.Add(CommonConstants.USER_SESSION, usSession);

                }
            }
            return RedirectToAction("Index", "HomeClient");
        }


        [HttpPost]
        public ActionResult Registered(MyViewModel mode)
        {
            var model = mode.Registered;

            if (ModelState.IsValid)
            {
                var login = new UserDAO();
                if(login.CheckUserName(model.UserName))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if(login.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                } 
                else
                {
                    var user = new User();
                    user.name = model.UserName;
                    user.password = Encrytor.MD5Hash(model.PassWord);
                    user.displayname = model.DisplayName;
                    user.phone = model.Phone;
                    user.email = model.Email;
                    user.date_created = DateTime.Now;

                    var result = login.Insert(user);
                    if(result > 0)
                    {
                        ViewBag.Success = "Đăng ký tài khoản thành công !!!";
                        model = new RegisteredClientModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký tài khoản không thành công !!!");
                    }
                }

            }
            return View("Index");
        }
    }
}