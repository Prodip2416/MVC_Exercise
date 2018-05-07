using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChildActionOnlyInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Countries(List<string> country)
        {
            return View(country);
        }
        public ActionResult Error()
        {
           throw new Exception("Something wen wrong");
        }
    }
}