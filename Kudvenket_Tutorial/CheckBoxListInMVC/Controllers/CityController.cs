using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CheckBoxListInMVC.Models;

namespace CheckBoxListInMVC.Controllers
{
    public class CityController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            SampleDBContext sampleDbContext = new SampleDBContext();
            return View(sampleDbContext.Cities);
        }
        [HttpGet]
        public ActionResult City()
        {
            SampleDBContext sampleDbContext = new SampleDBContext();
            List<SelectListItem> CityList= new List<SelectListItem>();

            foreach (City city in sampleDbContext.Cities)
              {
                SelectListItem selectList = new SelectListItem()
                {
                    Text =city.Name,
                    Value = city.ID.ToString(),
                    Selected = city.IsSelected
                 };
                CityList.Add(selectList);
              }
            Models.CityList cityList= new CityList()
            {
                Cities = CityList
            };
            
          
            return View(cityList);
        }
        [HttpPost]
        public string City(IEnumerable<string> selectedCities)
        {
            if (selectedCities == null)
            {
                return "No cities selected";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected - " + string.Join(",", selectedCities));
                return sb.ToString();
            }
        }
        [HttpPost]
        public string Index(IEnumerable<City> cities )
        {
            if (cities.Count(x => x.IsSelected) == 0)
            {
                return "You have not selected any City";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected - ");
                foreach (City city in cities)
                {
                    if (city.IsSelected)
                    {
                        sb.Append(city.Name + ", ");
                    }
                }
                sb.Remove(sb.ToString().LastIndexOf(","), 1);
                return sb.ToString();
            }
        }
    }
}