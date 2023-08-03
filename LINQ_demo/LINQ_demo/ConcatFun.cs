using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_demo
{
	public class ConcatFun
	{
		public void func()
		{
			List<string> collection1 = new List<string>() { "One", "Two", "Three" };
			List<string> collection2 = new List<string>() { "Five", "Six" };
			
			var data = collection1.Concat(collection2);
			foreach(var item in data) {
				Console.WriteLine(item);
			}
			
		}
	}
}
