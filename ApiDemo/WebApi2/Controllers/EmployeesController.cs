using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		//public string[] Emp = {"assd","dfse","rqwd" };
		//[HttpGet]
		//public string[] GetEmployeesName()
		//{
		//    return Emp;
		//}
		//[HttpGet]
		//public string GetEmployeesNameId(int id) {
		//    return Emp[id];        
		//}


		IDictionary<string, string> EmployeesDetails = new Dictionary<string, string>(){
		{"Name","xyz"},
		{"MobileNo.","70601XXXXX"},
		{"Emailid","user@binmile.com"}
			};

		
		//List<KeyValuePair<string, string>> Employeesdata = new List<KeyValuePair<string, string>>()
		//	{
		//		new KeyValuePair<string, string>("Name", "wdwqf"),
		//		new KeyValuePair<string, string>("Mobile", "242201XXXX"),
		//		new KeyValuePair<string, string>("Email", "user@accounts.com")
		//	};

		[HttpGet]
		public IDictionary<string, string> GetEmployeesDetails()
		{
			return EmployeesDetails;
		}

		//public List<KeyValuePair<string, string>> GetAllDetails()
		//{
		//	return Employeesdata;
		//}

	}
}
