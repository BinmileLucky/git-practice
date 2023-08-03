using System;

//namespace TotalArea
//{
//    class Circle
//    {
//       static void Main(string[] args)
//        {
//            const double pie = 3.14234;
//            double r;
//            r = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine(pie * r * r);
//        }

//    }
//}


//namespace TotalArea
//{
//    class gatherArea
//    {
//        public double l, b;

//        public void Area()
//        {
//            l = 5.1;
//            b = 4.2;

//        }

//        public double getArea()
//        {
//            return l * b;
//        }

//        public void Display()
//        {
//            Console.WriteLine(getArea());
//        }
//    }

//    class ExecuteArea
//    {
//        static void Main(String[] args) { 
//            gatherArea r= new gatherArea();
//            r.l = Convert.ToDouble(Console.ReadLine());
//            r.b = Convert.ToDouble(Console.ReadLine()); ;
//            //r.Area();
//            r.Display();


//        }
//    }
//}




//namespace Recursion
//{
//    class primeC
//    {
//        public int factorial (int x)
//        {
//            if (x==0 || x==1) return 1;
//            return factorial (x-1)*x;
//        }

//    }

//    class display
//    {
//        static void Main(string[] args)
//        {
//            primeC p = new primeC();
//            int x = p.factorial(3);
//            Console.WriteLine(x);
//        }
//    }
//}


//namespace array
//{
//    class myarray
//    {
//        static void Main(string[] args)
//        {
//            int[] arr=new int[10];
//            for(int i=0; i<arr.Length; i++)
//            {
//               arr[i]= Convert.ToInt32(Console.ReadLine());
//            } 

//            foreach(int j in arr) Console.WriteLine(j);
//        }
//    }
//}

//namespace firstString
//{
//    class mystring
//    {
//        static void Main(string[] args)
//        {
//            string[] starray = new string[]{"Down the way nights are dark",
//            "And the sun shines daily on the mountain top",
//            "I took a trip on a sailing ship",
//            "And when I reached Jamaica",
//            "I made a stop"};

//            string curr= String.Join("\n", starray); 
//            Console.WriteLine(curr);
//        }
//    }
//}



//namespace StaticVarApplication
//{
//    class StaticVar
//    {
//        public static int num;

//        public void count()
//        {
//            num++;
//        }
//        public int getNum()
//        {
//            return num;
//        }
//    }
//    class StaticTester
//    {
//        static void Main(string[] args)
//        {
//            StaticVar s1 = new StaticVar();
//            StaticVar s2 = new StaticVar();

//            s1.count();
//            s1.count();
//            s1.count();


//            Console.WriteLine("Variable num for s1: {0}", s1.getNum());

//            s2.count();
//            s2.count();
//            s2.count();
//            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
//            Console.ReadKey();
//        }
//    }
//}


namespace shape
{
    class Rectangle
    {
        protected int l, b;
        public void setlength()
        {
            this.l = 4;
            
        }
        public void setwidth()
        {
            this.b = 7;
        }
    }

    class getValue : Rectangle
    {
        public int area ()
        {
            return l * b;

        }
    }

    class myinherit
    {
        static void Main(string[] args)
        {
            getValue p = new getValue();
            p.setwidth ();
            p.setlength();
            Console.WriteLine(p.area());
        }
    }
}