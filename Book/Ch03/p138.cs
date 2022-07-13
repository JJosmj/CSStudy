using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p138
    {
        static void Main1(string[] args)
        {
            //변수를 선언합니다
            Console.Write("숫자를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());
            
            //조건문
            switch(input % 2)
            {
                case 0:
                    Console.WriteLine("짝수");
                    break;
                case 1:
                    Console.WriteLine("홀수");
                    break ;
            }

        }
    }
}
