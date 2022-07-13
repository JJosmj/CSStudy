using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p145
    {
        static void Main1(string[] args)
        {
            Console.Write("입력: ");
            string Line = Console.ReadLine();

            if (Line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세여..!");
            }
            else
            {
                Console.WriteLine("^^");
            }
        }
    }
}
