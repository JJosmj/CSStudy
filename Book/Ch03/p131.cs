using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p131
    {
        static void Main1(string[] args)
        {
            Console.Write("숫자입력: ");
            int input=int.Parse(Console.ReadLine());  

            if(input%2==0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전");
            }
            else
            {
                Console.WriteLine("오후");
            }
        }
    }
}
