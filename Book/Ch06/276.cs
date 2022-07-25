using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class _276
    {
        class MyMAth 
        {
            public static int Abs(int input)
            {
                if(input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }

        static void Main1(string[] args)
        {
            //int
            Console.WriteLine(MyMAth.Abs(52));
            Console.WriteLine(MyMAth.Abs(-273));

            //double
            Console.WriteLine(MyMAth.Abs(52.273));
            Console.WriteLine(MyMAth.Abs(-32.103));

            //long
            Console.WriteLine(MyMAth.Abs(21474836470));
            Console.WriteLine(MyMAth.Abs(-21474836470));

        }

    }
}
