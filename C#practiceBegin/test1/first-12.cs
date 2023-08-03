//using System;

//namespace TotalArea
//{
//    class Rectangle
//    {
//        static void Main(string[] args)
//        {
//            const double pi = 3.17234;
//            Console.WriteLine(pi);
//            double r;
//            r=Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine(r*pi*r);
//        }
//    }
//}

using System;

namespace DeclaringConstants
{

    class Program
    {

        static void Main(string[] args)
        {
            const double pi = 3.14159;

            // constant declaration 
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}