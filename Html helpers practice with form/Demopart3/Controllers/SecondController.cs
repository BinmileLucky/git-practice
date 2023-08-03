using Microsoft.AspNetCore.Mvc;

namespace Demopart3.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public ActionResult ContactUs()
        {
            return View();
        }



        public ActionResult AboutUs()
        {
            return View();
        }
    }
}
