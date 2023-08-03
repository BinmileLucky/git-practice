
namespace Fibonacci
{
	public class ConsoleApp
	{


		public static int Fibonacci(int num)
		{
			if (num == 0 || num==1) return num;
			
			return Fibonacci(num-1) + Fibonacci(num-2);
		}
		public static void Main(string[] args)
		{
			Console.Write("Enter  a Number : ");
			int num = Convert.ToInt32(Console.ReadLine());
			
			int finalOutput = Fibonacci(num);
			Console.WriteLine(finalOutput);
		}
	}
}