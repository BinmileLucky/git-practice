using Microsoft.AspNetCore.Mvc;
using Stronglytypedhtmlhelper.Models;

namespace Stronglytypedhtmlhelper.Controllers
{
	public class CalcController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Calculation c)
		{
			int n1 = c.num1;
			int n2 = c.num2;
			int result = n1 + n2;
			ViewBag.result = result;
			return View();
		}
	}
}
