using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelperInMVC.Models
{
    public class Company
    {
     //   public string CompanyName { get; set; }
        public string SelectDepartment { get; set; }

        //public Company(string companyName)
        //{
        //    CompanyName = companyName;
        //}
        //private string _name;
        //public Company(string name)
        //{
        //    this._name = name;
        //}

        public List<tblDepartment> Department
        {
            get
            {
                MVCDropDownList db= new MVCDropDownList();
                return db.tblDepartments.ToList();
            }
        }

        //public string CompanyName
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
    }
}