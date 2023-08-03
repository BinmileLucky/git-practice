using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_demo
{
	public class Student1
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int StandardID { get; set; }
		
	}

	public class Standard
	{
		public int StandardID { get; set; }
		public string StandardName { get; set; }
	}
	public class JoinsInner
	{
		public void clause3()
		{
						List<Student1> studentList = new List<Student1>() {
				new Student1() { StudentID = 1, StudentName = "John", StandardID =1 },
				new Student1() { StudentID = 2, StudentName = "Moin", StandardID =1 },
				new Student1() { StudentID = 3, StudentName = "Bill", StandardID =2 },
				new Student1() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
				new Student1() { StudentID = 5, StudentName = "Ron"  }
			};

						List<Standard> standardList = new List<Standard>() {
				new Standard(){ StandardID = 1, StandardName="Standard 1"},
				new Standard(){ StandardID = 2, StandardName="Standard 2"},
				new Standard(){ StandardID = 3, StandardName="Standard 3"}
			};

			//var data = (from student in studentList
			//			join standard in standardList
			//			  on student.StandardID equals standard.StandardID
			//			select new
			//			{
			//				Name = student.StudentName,
			//				Standard = standard.StandardName
			//			}).ToList();

			var data = studentList.Join(
				standardList,
				s => s.StandardID,
				st => st.StandardID,
				(s, st) => new
				{
					Name = s.StudentName,
					standard = st.StandardName
				}

				);



			foreach (var i in data)
				Console.WriteLine(i);
			
			
		}
	}
}
