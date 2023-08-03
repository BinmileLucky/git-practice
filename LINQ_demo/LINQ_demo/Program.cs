namespace LINQ_demo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int[] age = {19,20,21,23,45,35,78 };
			//select statement
			var a =from i in age where i>20 select i;

			foreach(int i in a)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine(" ");
			Console.WriteLine("----order by----- ");
			Console.WriteLine(" ");
			// orderby clause
			Orderby obj = new Orderby();
			obj.order();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with strings----- ");
			Console.WriteLine(" ");
			//strings
			working_WithStrings obj2 = new working_WithStrings();
			obj2.Strings();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with where Clause----- ");
			Console.WriteLine(" ");

			ClauseWhere obj3 = new ClauseWhere();
			obj3.Clause1();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with groupby Clause----- ");
			Console.WriteLine(" ");

			ClauseGroupBy obj4 = new ClauseGroupBy();
			obj4.Clause2();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with innerjoin Clause----- ");
			Console.WriteLine(" ");
			JoinsInner obj5 = new JoinsInner();
			obj5.clause3();


			Console.WriteLine(" ");
			Console.WriteLine("----Working with Groupjoin Clause----- ");
			Console.WriteLine(" ");
			JoinGroup obj6 = new JoinGroup();
			obj6.joinG();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with Select Clause----- ");
			Console.WriteLine(" ");
			ClauseSelect obj7= new ClauseSelect();
			obj7.clause4();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with Quantifier operator----- ");
			Console.WriteLine(" ");
			QuantifierOperator obj8= new QuantifierOperator();
			obj8.quantifier();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with Aggregate operator----- ");
			Console.WriteLine(" ");
			Aggreg obj9 = new Aggreg();
			obj9.ClauseAgg();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with Average and Count operator----- ");
			Console.WriteLine(" ");
			ClauseCount obj10 = new ClauseCount();
			obj10.ClauseCou();

			Console.WriteLine(" ");
			Console.WriteLine("----Working with Concat Function----- ");
			Console.WriteLine(" ");
			ConcatFun obj11= new ConcatFun();
			obj11.func();


			Console.WriteLine(" ");
			Console.WriteLine("----Working with Set Operators----- ");
			Console.WriteLine(" ");
			SetOperator obj12 = new SetOperator();
			obj12.Op();


		}
	}
}