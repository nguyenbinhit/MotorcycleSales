using System.Web.Mvc;

namespace WebXe.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HomeAD",
                "trang-thong-ke",
                new { action = "Index", controller = "HomeAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ColorAD",
                "mau-xe-ad",
                new { action = "Index", controller = "ColorAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ColorCreateAD",
                "them-moi-mau-xe-ad",
                new { action = "Create", controller = "ColorAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ColorEditAD",
                "cap-nhat-mau-xe-ad/{id}",
                new { action = "Edit", controller = "ColorAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "CarManufacturerAD",
                "hang-xe-ad",
                new { action = "Index", controller = "CarManufacturerAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "CarManufacturerCreateAD",
                "them-moi-hang-xe-ad",
                new { action = "Create", controller = "CarManufacturerAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "CarManufacturerEditAD",
                "cap-nhat-hang-xe-ad/{id}",
                new { action = "Edit", controller = "CarManufacturerAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "CategoryAD",
               "the-loai-xe-ad",
               new { action = "Index", controller = "CategoryAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "CategoryCreateAD",
                "them-moi-the-loai-xe-ad",
                new { action = "Create", controller = "CategoryAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "CategoryEditAD",
                "cap-nhat-the-loai-xe-ad/{id}",
                new { action = "Edit", controller = "CategoryAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "CylinderCapacityAD",
               "dung-tich-xi-lanh-xe-ad",
               new { action = "Index", controller = "CylinderCapacityAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "CylinderCapacityCreateAD",
                "them-moi-dung-tich-xi-lanh-xe-ad",
                new { action = "Create", controller = "CylinderCapacityAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "CylinderCapacityEditAD",
                "cap-nhat-dung-tich-xi-lanh-xe-ad/{id}",
                new { action = "Edit", controller = "CylinderCapacityAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "ProductAD",
               "san-pham-ad",
               new { action = "Index", controller = "ProductAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "ProductCreateAD",
                "them-moi-san-pham-ad",
                new { action = "Create", controller = "ProductAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ProductDetailAD",
                "chi-tiet-san-pham-ad/{id}",
                new { action = "Details", controller = "ProductAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ProductEditAD",
                "cap-nhat-san-pham-ad/{id}",
                new { action = "Edit", controller = "ProductAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "NewAD",
               "tin-tuc-ad",
               new { action = "Index", controller = "NewsAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "NewsCreateAD",
                "them-moi-tin-tuc-ad",
                new { action = "Create", controller = "NewsAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "NewsEditAD",
                "cap-nhat-tin-tuc-ad/{id}",
                new { action = "Edit", controller = "NewsAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "FeedbackAD",
               "danh-gia-binh-luan-ad",
               new { action = "Index", controller = "FeedbackAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
               "ContactAD",
               "lien-he-ad",
               new { action = "Index", controller = "ContactAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "ContactDetailAD",
                "chi-tiet-lien-he-ad/{id}",
                new { action = "Details", controller = "ContactAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "OrderAD",
               "don-hang-ad",
               new { action = "Index", controller = "OrdersAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
               "OrdersDetailAD",
               "chi-tiet-don-hang-ad/{id}",
               new { action = "Index", controller = "OrderDetailAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
               "UserAD",
               "khach-hang-ad",
               new { action = "Index", controller = "UsersAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "UsersDetailAD",
                "chi-tiet-khach-hang-ad/{id}",
                new { action = "Details", controller = "UsersAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "StaticPagesAD",
               "trang-tinh-ad",
               new { action = "Index", controller = "StaticPageAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "StaticPageCreateAD",
                "them-moi-trang-tinh-ad",
                new { action = "Create", controller = "StaticPageAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "StaticPageEditAD",
                "cap-nhat-trang-tinh-ad/{id}",
                new { action = "Edit", controller = "StaticPageAdmin", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "ADMINAD",
               "admin-nhan-vien-ad",
               new { action = "Index", controller = "ADNV", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "ADNVCreateAD",
                "them-moi-admin-nhan-vien-ad",
                new { action = "Create", controller = "ADNV", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ADNVDetailAD",
                "chi-tiet-admin-nhan-vien-ad/{id}",
                new { action = "Details", controller = "ADNV", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "ADNVEditAD",
                "cap-nhat-admin-nhan-vien-ad/{id}",
                new { action = "Edit", controller = "ADNV", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "LogoutAD",
               "dang-xuat-ad",
               new { action = "Index", controller = "LoginAdmin", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}