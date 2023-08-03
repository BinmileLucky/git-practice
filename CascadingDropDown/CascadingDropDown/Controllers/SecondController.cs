using CascadingDropDown.DTO;
using CascadingDropDown.Models;


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CascadingDropDown.Controllers
{
    public class SecondController : Controller
    {
        CascadingDropDownContext db = new CascadingDropDownContext();
        public IActionResult Index()
        {
            List<Country> data = db.Countries.ToList();
            ViewBag.CountryList = new SelectList(data, "CountryId", "CountryName");
            return View();
        }


		[HttpPost]	
		public IActionResult Details(string statename, string country)
		{
            var _Data = new CountryModel();
            _Data.CountryName = country;
            _Data.StateName=statename;
            db.SaveChanges();

            //ViewBag.DisplayCountry = c.CountryName;
            //ViewBag.DisplayState = c.StateName;
            return RedirectToAction("Index");
		}


        

		public JsonResult State(int cId)
        {
            var statedata = (from st in db.States where st.CountryId==cId
                            select new StateList
                            {
                                StateId=st.StateId,
                                StateName=st.StateName,
                            }).ToList();  

            return new JsonResult(statedata);
        }

		




	}
}
