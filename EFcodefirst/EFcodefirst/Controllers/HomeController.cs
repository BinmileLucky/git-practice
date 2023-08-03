using EFcodefirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace EFcodefirst.Controllers
{
	public class HomeController : Controller
	{
		private readonly EmployeeContext _context;

        public HomeController(EmployeeContext context)
        {
			_context = context;
        }

		//StudentContext db = new StudentContext();
		
        public IActionResult Index()
		{
			//IEnumerable<Student> objCatlist = _context.Students;
			var data = _context.Students.ToList();

			return View(data);
			
		}

		public IActionResult Create()
		{
			

			return View();

		}
		[HttpPost]
        public IActionResult Create(Student s)
        {
			_context.Students.Add(s);
			int a = _context.SaveChanges();
			if(a!=0)
			{
				ViewBag.Message = "<script>alert('Record Inserted Succesfully')</script>";
				ModelState.Clear();
			}
			else
			{
                ViewBag.Message = "<script>alert('Record Not Inserted')</script>";
            }

            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
           
			var row= _context.Students.Where(model=>model.Id==id).FirstOrDefault();
            return View(row);

        }
		[HttpPost]
        public IActionResult Edit(Student s)
        {
			_context.Entry(s).State=EntityState.Modified;
			int a= _context.SaveChanges();
            if (a != 0)
            {
                ViewBag.UpMessage = "<script>alert('Record Updated Succesfully')</script>";
                ModelState.Clear();
            }
            else
            {
                ViewBag.UpMessage = "<script>alert('Record Not  Updated')</script>";
            }

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {

            var row = _context.Students.Where(model => model.Id == id).FirstOrDefault();

            _context.Entry(row).State = EntityState.Deleted;
            int a = _context.SaveChanges();
            if (a != 0)
            {
                ViewBag.UpMessage = "<script>alert('Record Updated Succesfully')</script>";
                ModelState.Clear();
            }
            else
            {
                ViewBag.UpMessage = "<script>alert('Record Not  Updated')</script>";
            }

            return RedirectToAction("Index");

        }
    }
}
