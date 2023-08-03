using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ_demo.ClauseWhere;

namespace LINQ_demo
{
	public class Student2
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int StandardID { get; set; }
	}

	public class Standard1
	{
		public int StandardID { get; set; }
		public string StandardName { get; set; }
	}

	public class JoinGroup
	{
		public void joinG()
						{
							IList<Student2> studentList = new List<Student2>() {
					new Student2() { StudentID = 1, StudentName = "John", StandardID =1 },
					new Student2() { StudentID = 2, StudentName = "Moin", StandardID =1 },
					new Student2() { StudentID = 3, StudentName = "Bill", StandardID =2 },
					new Student2() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
					new Student2() { StudentID = 5, StudentName = "Ron" }
				};

							IList<Standard1	> standardList = new List<Standard1>() {
					new Standard1(){ StandardID = 1, StandardName="Standard 1"},
					new Standard1(){ StandardID = 2, StandardName="Standard 2"},
					new Standard1(){ StandardID = 3, StandardName="Standard 3"}
				};

			//var data = standardList.GroupJoin(
			//	studentList,
			//	stand => stand.StandardID,
			//	stud => stud.StandardID,
			//	(stand, stugroup) =>
			//	 new
			//	 {
			//		 studentdata=stugroup,
			//		 ID=stand.StandardName

			//	 }

			//	);


			var data = from std in standardList
					   join st in studentList on
					   std.StandardID equals st.StandardID
					   into studentgroup
					   select new
					   {
						   studentdata = studentgroup,
						   standardname = std.StandardName
					   };

			foreach(var i in data)
			{
				Console.WriteLine(i.standardname);
				foreach(var j in i.studentdata)
				{
					Console.WriteLine(j.StudentName);
				}
			}
		} 
	}
}
