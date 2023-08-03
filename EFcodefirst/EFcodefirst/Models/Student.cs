using System.ComponentModel.DataAnnotations;

namespace EFcodefirst.Models
{
	public class Student
	{
		[Key]
		public int Id { get; set; }
			public string Name { get; set; }

		public string Gender { get; set; }

		public int Age { get; set;}
	}
}
