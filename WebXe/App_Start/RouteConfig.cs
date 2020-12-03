using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebXe
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HomeClient",
                url: "trang-chu",
                defaults: new { controller = "HomeClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Introduce",
                url: "gioi-thieu",
                defaults: new { controller = "IntroduceClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Product",
                url: "san-pham",
                defaults: new { controller = "ProductClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "News",
                url: "tin-tuc",
                defaults: new { controller = "NewsClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "lien-he",
                defaults: new { controller = "ContactClient", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "dang-ky-dang-nhap",
                defaults: new { controller = "LoginClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Logout",
                url: "dang-xuat",
                defaults: new { controller = "LoginClient", action = "Logout", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "User",
                url: "khach-hang/{id}",
                defaults: new { controller = "UserClient", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Cart",
                url: "gio-hang",
                defaults: new { controller = "CartClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Color",
                url: "mau-sac-xe/{id}",
                defaults: new { controller = "ColorClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CarManufacturer",
                url: "hang-xe/{id}",
                defaults: new { controller = "CarManufacturerClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Category",
                url: "the-loai-xe/{id}",
                defaults: new { controller = "CategoryClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ProductDetail",
                url: "chi-tiet-san-pham/{id}",
                defaults: new { controller = "ProductClient", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NewsDetail",
                url: "noi-dung-tin-tuc/{id}",
                defaults: new { controller = "NewsClient", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Order",
                url: "don-hang/{id}",
                defaults: new { controller = "OrderClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "OrderDetail",
                url: "chi-tiet-don-hang/{id}",
                defaults: new { controller = "OrderDetailClient", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
