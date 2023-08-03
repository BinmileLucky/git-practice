using DataAnnotations.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotations.Controllers
{
	public class SecondController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Employee employee)
		{
			if(ModelState.IsValid == true)
			{
				ViewData["Message"] = "<script>alert('Data added succesfully') </script>";
				ModelState.Clear();
			}

			return View();
		}
	}
}
