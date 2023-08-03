//internal class Program
//{
//    private static void Main(string[] args)
//    {
//       try
//        {
//            int[] myarr = { 1, 2, 3, 4 };
//            Console.WriteLine(myarr[10]);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//            Console.WriteLine(ex.Message);
//            Console.WriteLine("NOPE");
//        }
//    }
//}



//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        string month = Console.ReadLine();

//        switch (month)
//        {
//            case "january":
//                {
//                    Console.WriteLine(1);
//                    break;
//                }
//            case "feburary":
//                {
//                    Console.WriteLine(2);
//                    break;
//                }
//            case "march":
//                {
//                    Console.WriteLine(3);
//                    break;
//                }
//            case "april":
//                {
//                    Console.WriteLine(4);
//                    break;
//                }
//            case "may":
//                {
//                    Console.WriteLine(5);
//                    break;
//                }
//            case "june":
//                {
//                    Console.WriteLine(6);
//                    break;
//                }
//            case "july":
//                {
//                    Console.WriteLine(7);
//                    break;
//                }
//            case "august":
//                {
//                    Console.WriteLine(8);
//                    break;
//                }
//            case "september":
//                {
//                    Console.WriteLine(9);
//                    break;
//                }
//            case "october":
//                {
//                    Console.WriteLine(10);
//                    break;
//                }
//            case "november":
//                {
//                    Console.WriteLine(11);
//                    break;
//                }
//            case "december":
//                {
//                    Console.WriteLine(12);
//                    break;

//                }
//            default:
//                {
//                    Console.WriteLine("invalid month or try in lower case");
//                    break;
//                }




//        }
//    }
//}




using System.Dynamic;
using ConsoleApp1;

internal class program
{
    private static void Main(string[] args)
    {
        //int[,] arr = new int[3, 3];
        //int k = 0;

        //for(int i=0; i<arr.GetLength(0); i++)
        //{
        //    for(int j=0; j<arr.GetLength(1); j++)
        //    {
        //        arr[i,j] = k;
        //        k++;
        //    }
        //}

        //int left = 0;
        //int right = 0;

        //Foor Loop Demo

        

        string decide=Console.ReadLine();

        switch(decide)
        {
            case "for":
                {
                    ForLoopDemo forLoopDemo = new ForLoopDemo();

                    var _result = forLoopDemo.GetResult();

                    Console.WriteLine(_result);

                    break;
                }

            case "while":
                {
                    WhileLoopDemo whileLoopDemo = new WhileLoopDemo();
                    int result =whileLoopDemo.whilefunction();
                    Console.WriteLine(result);
                    break;
                }
            default:
                {
                    Console.WriteLine("function not defined");
                    break;
                }
        }

    }
}