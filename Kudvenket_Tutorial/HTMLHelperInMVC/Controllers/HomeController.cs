using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelperInMVC.Models;

namespace HTMLHelperInMVC.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        { 
            return View();
        }

        //public ActionResult LoadDropDownList()
        //{
        //    Company company = new Company("Aushomapto");
        //    ViewBag.Department = new SelectList(company.Department, "Id", "Name");
        //    ViewBag.CompanyName = company.CompanyName;
        //    return View();
        //}
        //public ActionResult LoadDropDownList1()
        //{
        //    Company company = new Company("Aushomapto");

        //    return View(company);
        //}
        [HttpGet]
        public ActionResult LoadRadioButton()
        {
            Company company = new Company();

            return View(company);
        }
        [HttpPost]
        public string LoadRadioButton(Company company)
        {
            if (string.IsNullOrEmpty(company.SelectDepartment))
            {
                return "You do not have select any department";
            }
            else
            {
                return "You Have select department with Id = " + company.SelectDepartment;
            }

        }
    }
}