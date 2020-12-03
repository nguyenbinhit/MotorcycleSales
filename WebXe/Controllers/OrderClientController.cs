using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Controllers
{
    public class OrderClientController : Controller
    {
        // GET: OrderClient
        public ActionResult Index(int id, int page = 1, int pageSize = 5)
        {
            var order = new OrderDAO();
            var model = order.OrderByUser(id, page, pageSize);

            return View(model);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new OrdersDetailDAO().Delete(id);

            new OrderDAO().Delete(id);

            return RedirectToAction("Index");
        }
    }
}