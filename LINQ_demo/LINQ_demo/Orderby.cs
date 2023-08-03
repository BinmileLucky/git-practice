using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static LINQ_demo.ClauseWhere;

namespace LINQ_demo
{
	public class Orderby: Student
	{
		public void order()
		{
			//k = from i in x where i > 20 orderby i descending select i;
			

							List<Student> studentList = new List<Student>() {
					new Student() { StudentID = 1, StudentName = "John", Age=21 },
					new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
					new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
					new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
					new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
				};
			var d= from s in studentList orderby s.StudentName descending select s.StudentName;
			foreach (var i in d)
			{
				Console.WriteLine(i);
			}
		}
	}
}
