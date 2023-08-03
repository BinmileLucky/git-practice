using Microsoft.AspNetCore.Mvc;

namespace Validation.Controllers
{
	public class SecondController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string Fullname,string Age,string Email)
		{
			if (Fullname.Equals("") == true)
			{
				ModelState.AddModelError("Fullname", "Fullname is required !!");
			}
			if (Age.Equals("") == true)
			{
				ModelState.AddModelError("Age", "Age is required !!");
			}
			if (Email.Equals("") == true)
			{
				ModelState.AddModelError("Email", "Email is required !!");
			}
			if(ModelState.IsValid == true)
			{
				ViewData["Message"] = "<script>alert('Data has been added succesfully !!')</script>";
			}

			return View();
		}
	}
}
