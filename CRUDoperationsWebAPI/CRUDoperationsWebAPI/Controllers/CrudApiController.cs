using CRUDoperationsWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDoperationsWebAPI.Controllers
{
	[Route("api/[Controller]")]
	[ApiController]
	public class CrudApiController : Controller
	{
		RegistartionDetailsContext db = new RegistartionDetailsContext();

		[HttpGet]
		public async Task<ActionResult<IEnumerable<EmployeeDetail>>>  GetEmployess()
		{
			return await db.EmployeeDetails.ToListAsync();

			
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<EmployeeDetail>> GetEmployess(int id)
		{
			var data = await db.EmployeeDetails.FindAsync(id);

			

			return data;
		}
		[HttpPost]
		public async Task<ActionResult<EmployeeDetail>> PostEmployess(EmployeeDetail e)
		{
			 db.EmployeeDetails.Add(e);
			await db.SaveChangesAsync();	


			return CreatedAtAction(nameof(GetEmployess), new { id = e.Id} , e);
		}


		[HttpPut]

		public async Task<IActionResult> PutEmployees(int id,EmployeeDetail e)
		{
			db.Entry(e).State = EntityState.Modified;
			await db.SaveChangesAsync();
			return Ok();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteEmployees(int id)
		{
			var row = await db.EmployeeDetails.FindAsync(id); ;

			db.Entry(row).State = EntityState.Deleted;
			await db.SaveChangesAsync();
			return Ok();
		}

	}
}
