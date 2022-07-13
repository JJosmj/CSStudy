using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p127
    {
        static void Main1(string[] args)
        {
            Console.Write("숫자입력: ");
            int input = int.Parse(Console.ReadLine());

            if(input %2 == 0)
            {
                Console.WriteLine("짝수");                
            }
            if(input %2 == 1)
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
