using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_demo
{
	public class SetOperator
	{
		public void Op()
		{
			List<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
			List<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };
			var data1= strList1.Except(strList2).ToList();
			var data2 = strList1.Intersect(strList2);
			var data3 = strList1.Union(strList2);

			Console.WriteLine("---Except Set operator---");
			foreach( var i in data1)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("---Intersect Set operator---");
			foreach (var i in data2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("---Union Set operator---");
			foreach (var i in data3)
			{
				Console.WriteLine(i);
			}

		}
	}
}
