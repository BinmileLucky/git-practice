using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_demo
{
	public class ClauseWhere
	{

		public class Student
		{
			public int StudentID { get; set; }
			public string StudentName { get; set; }
				
			public int Age { get; set; }
		}
		public void Clause1()
		{ 
	
						List<Student> studentList = new List<Student>() {
					new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
					new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
					new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
					new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
					new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
				};

			 var filteredName= from s in studentList 
				where s.Age>12 && s.Age<18 
				select s.StudentName;
			foreach(var i in filteredName)
			{
				Console.WriteLine(i);
			}
		}
	}
}
