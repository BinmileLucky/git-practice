using Microsoft.AspNetCore.Mvc;
using SimpleInterestCalc.Models;



namespace SimpleInterestCalc.Controllers
{
	public class SimpleInterestController : Controller
	{
		public IActionResult Index(SIModel s)
		{
			return View(s);
		}

		

		

	}
}