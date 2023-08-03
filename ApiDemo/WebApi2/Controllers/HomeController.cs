using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
