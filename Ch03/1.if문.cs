using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2022/7/13
 * 조건문 if 실습하기 교재 p127
 * 
 */
namespace Ch03
{
    internal class _1
    {
        static void Main1(string[] args)
        {
            //if
            int a1 = 1;
            int a2 = 2;
            
            if(a1<a2)
            { //참이면 실행
                Console.WriteLine("a1이 a2보다 작다.");
            }

            if(a1<0)
            {
                Console.WriteLine("a1은 0보다 작다");
            }

            if(a1>0)
            {
                if(a2>1)
                { Console.WriteLine("a1은 0보다 크고, a2는 1보다 크다"); 
                }
            }

            if(a1>0 && a2>1)
            {
                Console.WriteLine("a1은 0보다크고 그리고 a2는 1보다 크다");
            }

            //if ~else
            int b1 = 1, b2 = 2;
            if (b1>b2) 
            {
                //참
                Console.WriteLine("b1이 b2보다 크다");
            }
            else
            {
                //거짓
                Console.WriteLine("b1이 b2보다 작다");
            }
            //if ~else if ~else
            int c1 = 1, c2 = 2,c3 = 3, c4 = 4;

            if(c1>c2)
            {
                Console.WriteLine("c1이 c2보다 크다"); 
            }
            else if(c2>c3)
            {
                Console.WriteLine("c2이 c3보다 크다");
            }
            else if(c3>c4)
            {
                Console.WriteLine("c3이 c4보다 크다");
            }
            else
            {
                Console.WriteLine("c4가 가장 크다");
            }
        }
    }
}
