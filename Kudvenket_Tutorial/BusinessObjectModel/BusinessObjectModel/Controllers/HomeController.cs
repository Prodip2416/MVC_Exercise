using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace BusinessObjectModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusiness= new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusiness.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }
        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employees= new EmployeeBusinessLayer();
            Employee employee = employees.Employees.Single(e => e.EmployeeId == id);
            return View(employee);
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit()
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employees= new EmployeeBusinessLayer();

                Employee employee= new Employee();
                UpdateModel(employee);
                employees.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_POst()
        {
             //    Employee employee = new Employee();
            // Retrieve form data using form collection
            //    employee.Name = name;
            //    employee.Gender = gender;
            //    employee.City = city;
            //    employee.DateTime = datetime;

            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer =
                new EmployeeBusinessLayer();
                
                Employee employee = new Employee();
                UpdateModel(employee);
                employeeBusinessLayer.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer= new EmployeeBusinessLayer();
          
            employeeBusinessLayer.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}