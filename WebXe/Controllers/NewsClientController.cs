using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebXe.Controllers
{
    public class NewsClientController : Controller
    {
        // GET: NewsClient
        public ActionResult Index(string search, int page = 1, int pageSize = 12)
        {
            var listAllNews = new NewsDAO();
            var model = listAllNews.ListAllPage(search, page, pageSize);
            ViewBag.Search = search;

            return View(model);
        }

        // GET: NewsClient/Details/5
        public ActionResult Details(int id)
        {
            var news = new NewsDAO().ViewDetail(id); 
            return View(news);
        }
    }
}
