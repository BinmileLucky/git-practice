using Microsoft.AspNetCore.Mvc;

namespace PartialViewsIm.Controllers
{
    public class PartialInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult ContactUs()
		{
			return View();
		}
	}
}
