using Microsoft.AspNetCore.Mvc;

namespace RouteConfig.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
