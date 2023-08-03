using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
	public class Employee
	{
		
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Gender { get; set; }
		[Required]
		[Range(0,60)]
		public int Age { get; set; }
		[Required]
		[RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$",ErrorMessage ="Invalid Email")]
		public string Email { get; set;}
		[Required]
		[Compare("Email")]
		public string ConfirmEmail { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public string joiningDate { get; set; }

	}
}
