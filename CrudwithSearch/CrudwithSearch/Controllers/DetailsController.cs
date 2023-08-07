using System.Linq;
using CrudwithSearch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PagedList;
//using Model PagedList<CrudwithSearch.Models.EmployeeDetail>

namespace CrudwithSearch.Controllers
{
    public class DetailsController : Controller
    {
        RegistartionDetailsContext db = new RegistartionDetailsContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddData(EmployeeDetail e)
        {
             db.EmployeeDetails.Add(e);
            int a = db.SaveChanges();
            return RedirectToAction("Index");
        }
     
        public IActionResult GetData(int PageNumber=1)
        {

                  
                var data = db.EmployeeDetails.Skip((PageNumber-1)*4).Take(4).ToList();
          ViewBag.TotalPages = db.EmployeeDetails.Count() /3;
            ////filter
            //var pagedEmp = new PagedList<EmployeeDetail>(data, pageno, pagesize);

                return View(data);
            
        }

        [HttpPost]
        public ActionResult SearchData(string name)
        {


            var sd = db.EmployeeDetails.Where(model => model.EmpName == name).ToList();
                return View(sd);
            
            
        }

        public IActionResult Edit(int id)
        {

            var row = db.EmployeeDetails.Where(model => model.Id == id).FirstOrDefault();


            return View(row);


        }

        public IActionResult Delete(int id)
        {

            var row = db.EmployeeDetails.Where(model => model.Id == id).FirstOrDefault();

            db.Entry(row).State = EntityState.Deleted;
            int a = db.SaveChanges();
            return RedirectToAction("Index");


        }


    }
}
