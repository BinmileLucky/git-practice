using Microsoft.AspNetCore.Mvc;
using secondMVC.Models;

namespace secondMVC.Controllers
{
    public class SecondController : Controller
    {
        private object Session;

        public IActionResult Index()
        {
            ViewData["Title"] = "first assignmnt";
            ViewData["currentTime"]=DateTime.Now.ToLongTimeString();

            string[] fruit = {"orange","mango","papaya","guava" };
            ViewData["fruitsName"] = fruit;

            List<string> Sports = new List<string>()
            {
                "cricket",
                "football",
                "hockey",
                "squash"
            };
            ViewData["SportsItem"] = Sports;


            Employee Lucky = new Employee();
            Lucky.Name = "act21";
            Lucky.Id = 1;
            Lucky.Email = "lucky@binmile.com";

            //ViewData["EmployeesDetails"] = Lucky;
            ViewBag.x= Lucky;
            ViewData["first"] = "this is viewData";
            ViewBag.second = "this is viewbag";
            //TempData["third"] = "this is tempdata";
            //Session["username"] = "this is a sessiion page";
            return View();
        }



        public ActionResult About()
        {
            if (TempData["third"]!=null)
            {
                TempData["third"].ToString();
            }
            return View();
        }

        public string home()
        {
            return "this is second method";
        }

       
    }
}
