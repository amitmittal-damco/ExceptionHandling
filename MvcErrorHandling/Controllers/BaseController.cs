using MvcErrorHandling.App_Start;
using System.Web.Mvc;

namespace MvcErrorHandling.Controllers
{
    [CustomHandleError()]
    public class BaseController : Controller
    {
        
    }
}
