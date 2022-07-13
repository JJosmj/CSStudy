using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 조건문 Switch 실습하기 겨재 p127
 * 
 */
namespace Ch03
{
    internal class _2
    {
        static void Main2(string[] args)
        {
            Console.Write("숫자 입력 :");
            string strnum =Console.ReadLine();

            int number = int.Parse(strnum);

            switch(number % 2)
            {
                case 0:
                    Console.WriteLine($"{number}는 짝수");
                    break;
                case 1:
                    Console.WriteLine($"{number}는 홀수");
                    break;
            }
        }
    }
}
