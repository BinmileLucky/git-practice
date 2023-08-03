using System.Data.SqlClient;
using EmployeeRegistrationDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ConnectingDB;
using System.Configuration;
using System.Data;
using System.Security.Claims;
using System.Drawing;

namespace EmployeeRegistrationDemo.Controllers
{


    public class SecondController : Controller
    {
        private readonly IConfiguration configuration;
        public SecondController(IConfiguration _config)
        {
            configuration = _config;
        }

        //private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            

            return View(); 

        }




        [HttpPost]
        [ActionName("RegForm")]
        public IActionResult RegForm(Employee employee)
        {

            StudentDBHandle obj = new StudentDBHandle(configuration);
            obj.AddEmployee(employee);


            
            return RedirectToAction("Index");

        }

        public IActionResult ShowData()
        {
            StudentDBHandle dbhandle = new StudentDBHandle(configuration);

            List<Employee> obj = dbhandle.DisplayForm();

            return View(obj);

        }

        public IActionResult Edit(int id)
        {
            StudentDBHandle dbhandle = new StudentDBHandle(configuration);
            //var row = dbhandle.DisplayForm(id);
            //dbhandle.UpdateEmployee(id);
            var row = dbhandle.DisplayForm().Where(x => x.ID == id).FirstOrDefault();
            return View(row);

        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditDetails( Employee employee)
		{
			StudentDBHandle dbhandle = new StudentDBHandle(configuration);

            dbhandle.UpdateEmployee(employee);
			return RedirectToAction("ShowData");

		}

		public IActionResult Delete(int id)
        {
            
            StudentDBHandle dbhandle = new StudentDBHandle(configuration);
            dbhandle.DeleteEmployee(id);

            return RedirectToAction("ShowData");

            }
           


        }
    }

    
