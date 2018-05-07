using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeletingMultipleRowsInMvc.Models;

namespace DeletingMultipleRowsInMvc.Controllers
{
    public class EmployeeController : Controller
    {
        SampleDBContext db= new SampleDBContext();
        public ActionResult Index()
        {       
            return View(db.Employees.ToList());
        }
        public ActionResult Delete(IEnumerable<int> deleteIdEmployee )
        {
            db.Employees.Where(x => deleteIdEmployee.Contains(x.EmployeeId)).ToList().ForEach(db.Employees.d);
          
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}