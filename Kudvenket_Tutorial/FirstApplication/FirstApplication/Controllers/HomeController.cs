using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }

        public ActionResult Country()
        {
           ViewData["Country"]= new List<string>()
            {
                "Bangladesh",
                "India",
                "USA",
                "UK"
            };
            return View();
        }
        public string About()
        {
            return "Hello from MVC Application";
        }

        public string Contact()
        {
            return "prodip2416@gmail.com";
        }

        public string GetDetails(string id)
        {
            return "Id = "+ id+" Name = "+Request.QueryString["name"];
        }
    }
}