using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWithAspNetMVC.Models;

namespace AjaxWithAspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        SampleDbContext db = new SampleDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult GetAllStudent()
        {
            List<Student> model = db.Students.ToList();
            return PartialView("_Student", model);
        }
        public PartialViewResult GetTop3Student()
        {
            List<Student> model = db.Students.OrderByDescending(x => x.TotalMarks).Take(3).ToList();
            return PartialView("_Student", model);
        }
        public PartialViewResult GetButtom3Student()
        {
            List<Student> model = db.Students.OrderBy(x => x.TotalMarks).Take(3).ToList();
            return PartialView("_Student", model);
        }
    }
}