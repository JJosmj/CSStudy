using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class _96
    {
        static void Main1(string[] args)
        {
            int n = 10;
            Console.WriteLine(n++);
            Console.WriteLine(++n);
            Console.WriteLine(n--);
            Console.WriteLine(--n);

            int a = 10;
            Console.WriteLine(a);
            a++;
            a++;
            Console.WriteLine(a);
            Console.WriteLine(a);
            a--;
            a--;
            Console.WriteLine(a);
        }
    }
}
