using System.Web;
using System.Web.Mvc;

namespace DisplayNameDisplayFortmate
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
