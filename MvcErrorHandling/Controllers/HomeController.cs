using System.Web.Mvc;
namespace MvcErrorHandling.Controllers
{

    public class HomeController : BaseController
    {
        public ActionResult Index(string str = "test Model")
        {
            var s = 3;
            var e = 0;
            var es = s / e;
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}
