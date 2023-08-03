using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ_demo.ClauseWhere;

namespace LINQ_demo
{
	public class ClauseCount : Student
	{
		public void ClauseCou()
		{
			List<Student> studentList = new List<Student>() {

				new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
				new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
			};

			var ageData = studentList.Count(s => s.Age >=12);

			var avgAgeData = studentList.Average(s => s.Age );
			var oldest = studentList.Max(s => s.Age);
			var totalAge = studentList.Sum(s => s.Age);
			Console.WriteLine("Count of Age : "+ ageData);
			Console.WriteLine("Average is : " + avgAgeData);
			Console.WriteLine("Max Age is : " + oldest);
			Console.WriteLine("Total Age is : " + totalAge);

		}
	}
}
