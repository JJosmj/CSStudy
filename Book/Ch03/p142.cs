using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p142
    {
        static void Main1(string[] args)
        {
            int number = 1;
           
            //참과 거짓 위치에 불 자료형 사용
            Console.WriteLine(number % 2==0? true : false);

            //참과 거짓 위치에 문자열 자료형 사용
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
