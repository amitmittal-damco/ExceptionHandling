using MvcErrorHandling.App_Start;
using System.Web.Mvc;

namespace MvcErrorHandling
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomHandleErrorAttribute());

        }
    }
}