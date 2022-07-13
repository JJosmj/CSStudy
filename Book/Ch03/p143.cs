using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p143
    {
        static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);

            //조건 구분
            Console.WriteLine(number > 0 ? "자연수" : "자연수가 아니다");
        }
    }
}
