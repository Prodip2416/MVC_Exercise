using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImplementAutocompleteTextboxFunctionalityMVC.Models;

namespace ImplementAutocompleteTextboxFunctionalityMVC.Controllers
{
    public class HomeController : Controller
    {
        SampleDBContext db = new SampleDBContext();
        public ActionResult Index()
        {
            List<Students> student = db.Students.ToList();
            return View(student);
        }
        [HttpPost]
        public ActionResult Index(string search)
        {
            List<Students> student;
            if (string.IsNullOrEmpty(search))
            {
                student = db.Students.ToList();
            }
            else
            {
                student = db.Students.Where(x => x.Name.StartsWith(search)).ToList();
            }
            return View(student);
        }

        public JsonResult GetStudents(string term)
        {
            List<string> student;

            student = db.Students.Where(x => x.Name.StartsWith(term)).Select(y => y.Name).ToList();
          
            return Json(student, JsonRequestBehavior.AllowGet);
        }
    }
}