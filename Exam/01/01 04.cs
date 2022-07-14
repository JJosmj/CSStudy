using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_04
    {
        static void Main1(string[] args)
        {
            int n = 1;
            int result;

            result = n++;
            Console.WriteLine("result: " +result);

            result = ++n;
            Console.WriteLine("result: " + result);

            result = n--;
            Console.WriteLine("result: " + result);

            result = --n;
            Console.WriteLine("result: " + result);
        }
    }
}
