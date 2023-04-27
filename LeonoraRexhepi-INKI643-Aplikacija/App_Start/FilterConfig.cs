using System.Web;
using System.Web.Mvc;

namespace LeonoraRexhepi_INKI643_Aplikacija
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
