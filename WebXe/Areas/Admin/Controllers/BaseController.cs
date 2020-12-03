using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebXe.Common;

namespace WebXe.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (AccountLogin)Session[CommonConstants.ACCOUNT_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "Index", controller = "LoginAdmin", Areas = "Admin" }));
            }

            base.OnActionExecuting(filterContext);
        }
    }
}