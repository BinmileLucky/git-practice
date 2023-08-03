using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_demo
{
	public class ClauseGroupBy: ClauseWhere
	{

		public void Clause2() {

				List<Student> studentList = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
			new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
			new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
			new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
				};

			var groupedResult = from s in studentList group s by s.Age;

			foreach(var i in groupedResult)
			{
				Console.WriteLine(i.Key);
				foreach(var s in i)
				{
					Console.WriteLine(s.StudentName);
				}	
			}
		}
		
	}
}
