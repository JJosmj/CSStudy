using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._1단
{
    internal class _01_08
    {
        static void Main1(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);

            Console.WriteLine(a / b);
        }
    }
}
