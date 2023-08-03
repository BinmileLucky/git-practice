using Microsoft.EntityFrameworkCore;

namespace EFcodefirst.Models
{
	public class EmployeeContext : DbContext
 	{

        public EmployeeContext(DbContextOptions options) : base(options) { }




        public DbSet<Student> Students { get; set; }

	}
}
