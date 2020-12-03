using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXe.Models;

namespace WebXe.Controllers
{
    public class OrderDetailClientController : Controller
    {
        // GET: OrderDetailClient
        public ActionResult Index(int id)
        {
            var orderDetail = new OrdersDetailDAO().Detail(id);

            List<OrderDetailClientModel> listO = new List<OrderDetailClientModel>();
            foreach (var item in orderDetail)
            {
                var detail = new OrderDetailClientModel();
                detail.BillID = item.id_Bill;
                detail.ID = item.id;
                detail.ProductID = item.Product.id;
                detail.ProductName = item.Product == null ? string.Empty : item.Product.name;
                detail.Price = item.price;
                detail.Qty = item.qty;
                detail.ProductImage = item.Product.imagemain;
                listO.Add(detail);
            }
            ViewBag.Product = listO;

            var order = new OrderDAO().Detail(id);
            ViewBag.Order = order;

            return View();
        }
    }
}