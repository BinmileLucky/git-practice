using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json;
using System.Collections.Generic;
using RegistrationFormDetails.Models;

namespace RegistrationFormDetails.Controllers
{
	public class FormController : Controller
	{
        RegistartionDetailsContext db = new RegistartionDetailsContext();   
        public IActionResult Index()
		{


            //var data = db.EmployeeDetails.ToList();

            //return View(data);

            return View();
        }
        [HttpPost]
        public IActionResult AddEmployeeData(EmployeeDetail e)
        {
            

            db.EmployeeDetails.Add(e);
            int a = db.SaveChanges();
            if (a != 0)
            {
                
                ModelState.Clear();
            }

          
            return Ok();

        }

        public JsonResult DataDisplay()
        {


            var data = db.EmployeeDetails.ToList();
           
            return new JsonResult(data);


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
