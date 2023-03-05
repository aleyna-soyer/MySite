using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomeView
        public ActionResult Index()
        {
            return View();
        }
    }
}