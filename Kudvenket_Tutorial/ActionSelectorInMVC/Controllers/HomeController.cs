using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionSelectorInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
     
        [ActionName("List")]
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}