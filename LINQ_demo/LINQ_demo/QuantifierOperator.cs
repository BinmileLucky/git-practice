﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ_demo.ClauseWhere;

namespace LINQ_demo
{
	public class QuantifierOperator: Student
	{
		public void quantifier()
		{
					List<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
			};

			bool allValues = studentList.All(s => s.Age > 12 && s.Age < 20);
			bool anyvalues = studentList.Any(s=> s.Age>12 && s.Age < 20);	
			
			Console.WriteLine(allValues);
			Console.WriteLine(anyvalues);
		}

	}
}
