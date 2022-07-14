using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._1단
{
    internal class _01_12
    {
        static void Main1(string[] args)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');

            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);
            int C = int.Parse(numbers[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
