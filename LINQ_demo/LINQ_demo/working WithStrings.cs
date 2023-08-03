using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_demo
{
	public class working_WithStrings
	{
		public void Strings()
		{
			string [] names = {"yatch","prashant","adil","watch" };

			var a = from name in names
					where name.Contains('t')
					select name;

			//Console.WriteLine("Data");
			foreach (string name in a) {
			Console.WriteLine(name);
			
			}
		}
	}
}
