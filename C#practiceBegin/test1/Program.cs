/*using System;
namespace RectangleArea
{
    class Rectangle
    {
        
        double l, b;

        public void getPara()
        {
            l = 5.4;
            b = 4.2;
        }
        public double getArea()
        {
            return l * b;
        }
        public void print()
        {
            Console.WriteLine(l);
            Console.WriteLine(b);
            Console.WriteLine(getArea());
        }
    }

    class ExecuteArea
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.getPara();
            r.print();
            //Console.ReadLine();
        }
    }
}*/


using System;

namespace TypeConversionApplication
{
    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();

        }
    }
}
