using Models.DAO;
using Models.EF;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Script;
using System.Web.Script.Serialization;
using WebXe.Common;
using WebXe.Models;

namespace WebXe.Controllers
{
    public class CartClientController : Controller
    {
        private const string CartSession = "CartSession";
        // GET: CartClient
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItemModel>();
            if (cart != null)
            {
                list = (List<CartItemModel>)cart;
            }

            return View(list);
        }

        public ActionResult AddItem(int product_ID, int qty)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            if (session == null)
            {
                ViewBag.Login = "Bạn cần phải đăng nhập trước khi thêm sản phẩm vào giỏ hàng";
                return RedirectToAction("Index", "LoginClient");
            }
            else
            {
                var product = new ProductDAO().ViewDetail(product_ID);
                var cart = Session[CartSession];
                if (cart != null)
                {
                    var list = (List<CartItemModel>)cart;
                    if (list.Exists(x => x.Product.id == product_ID))
                    {
                        foreach (var item in list)
                        {
                            if (item.Product.id == product_ID)
                            {
                                item.Qty += qty;
                            }
                        }
                    }
                    else
                    {
                        //create a new cart item
                        var item = new CartItemModel();
                        item.Product = product;
                        item.Qty = qty;
                        list.Add(item);
                    }
                    //assigned to the session
                    Session[CartSession] = list;
                }
                else
                {
                    //create a new cart item
                    var item = new CartItemModel();
                    item.Product = product;
                    item.Qty = qty;
                    var list = new List<CartItemModel>();
                    list.Add(item);

                    //assigned to the session
                    Session[CartSession] = list;
                }
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItemModel>>(cartModel);
            var sessionCart = (List<CartItemModel>)Session[CartSession];

            foreach(var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.Product.id == item.Product.id);
                if(jsonItem != null)
                {
                    item.Qty = jsonItem.Qty;
                    
                }
            }

            return Json(new {
                status = true
            });
        }

        [HttpPost]
        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;

            return Json(new
            {
                status = true
            });
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var sessionCart = (List<CartItemModel>)Session[CartSession];
            sessionCart.RemoveAll(x => x.Product.id == id);
            Session[CartSession] = sessionCart;

            return Json(new
            {
                status = true
            });
        }

        [HttpGet]
        public ActionResult Payment()
        {
            var cart = Session[CartSession];
            var list = new List<CartItemModel>();
            if (cart != null)
            {
                list = (List<CartItemModel>)cart;
            }

            return View(list);
        }

        [HttpPost]
        public ActionResult Payment(string shipId, string amount, string shipNote)
        {
            var order = new Order();
            order.date_created = DateTime.Now;
            order.id_User = Convert.ToInt32(shipId);
            order.note = shipNote;
            order.status = 0;
            order.amount = Convert.ToDouble(amount);
            try
            {
                var id = new OrderDAO().Insert(order);
                var cart = (List<CartItemModel>)Session[CartSession];
                var detail = new OrdersDetailDAO();
                foreach (var item in cart)
                {
                    var ordersDetail = new OrdersDetail();
                    ordersDetail.id_Product = item.Product.id;
                    ordersDetail.id_Bill = (int)id;
                    ordersDetail.price = item.Product.price;
                    ordersDetail.qty = item.Qty;
                    ordersDetail.date_created = DateTime.Now;
                    detail.Insert(ordersDetail);
                }
            }
            catch
            {
                return RedirectToAction("Error", "CartClient");
            }
            return RedirectToAction("Sussecc", "CartClient");
        }

        [HttpGet]
        public ActionResult Sussecc()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }
    }
}