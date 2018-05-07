using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NonActionAttributes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        private string Index()
        {
            return "Action Method";
        }
    }
}