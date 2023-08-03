using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ_demo.ClauseWhere;

namespace LINQ_demo
{
	public class Aggreg : Student
	{
		public void ClauseAgg()
		{
			List<Student> studentList = new List<Student> () {

						new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
				new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
			};

			var data = studentList.Aggregate<Student, string>("StudentName : ",
				(str, s) => str += s.StudentName + ","

				); 
			Console.WriteLine( data );
		}
		
	}
}
