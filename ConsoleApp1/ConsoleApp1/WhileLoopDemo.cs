using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WhileLoopDemo
    {

      public int whilefunction()
        {
            int sm = 0;
            int x = 10, i = 0;
            while (i < x)
            {
                sm+=i;
                i++;
            }
            return sm;

        }
    }
}
