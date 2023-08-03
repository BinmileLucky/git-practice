using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ForLoopDemo
    {

        public int GetResult()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }

            return sum;
    }
    }


}
