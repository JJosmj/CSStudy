using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p108
    {
        static void Main1(string[] args)
        {
            long longnumber = 2147483647L + 2147483647L;
            int longToint = (int)longnumber;
            Console.WriteLine(longToint);

            double doubleNumber = 52.27310332;
            int doubleToint = (int)doubleNumber;
            Console.WriteLine(doubleToint);
        }
    }
}
