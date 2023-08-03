using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ_demo.ClauseWhere;

namespace LINQ_demo
{
	public class ClauseSelect : Student
	{
		public void clause4()
		{
					IList<Student> studentList = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
			new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
			new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
			new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
				};

			var data = studentList.Select(x => new
			{
				Name = x.StudentName,
				Age = x.Age

			});

			//var selectResult = from s in studentList
			//				   select new { Name = "Mr. " + s.StudentName, Age = s.Age };


			foreach (var i in data)
			{
				Console.WriteLine("Name : "+ i.Name+ " " + "Age : "+ i.Age);
			}

		}
	}
}
