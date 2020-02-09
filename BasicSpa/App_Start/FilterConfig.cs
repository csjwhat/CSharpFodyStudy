using System.Web;
using System.Web.Mvc;
using AutoLogger;

namespace BasicSpa
{
    public class FilterConfig
    {
        [Logger]
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
