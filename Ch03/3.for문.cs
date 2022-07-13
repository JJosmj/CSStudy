using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 반복문 For 실습하기 교재 p157
 * 
 * 
 */
namespace Ch03
{
    internal class _3
    {
        static void Main1(string[] args)
        {
            //for
            for(int i=1 ;i<=5 ;i++ )
            {
                Console.WriteLine("{0}회 반복..",i);
            }

            //1부터 10까지 합
            int sum=0;

            for(int k=1;k<=10; k++)
            {
                sum += k;
            }
            Console.WriteLine("1부터 10까지 합:"+sum);

            //1부터 10까지 짝수합
            int t = 0;
            
            for(int j=1;j<=10;j++)
            {
                if (j % 2 == 0)
                {
                    t += j;
                }
            }
            Console.WriteLine("1부터 10까지 짝수 합:"+t);
            //중첩 for문
            for (int a = 1; a <= 3; a++)
            {
                Console.WriteLine("a:"+a);
                for (int b = 1; b <= 4; b++)
                {
                    Console.WriteLine("b:"+b);
                }
                        
            }
            //구구단
            for(int x=2;x<=9;x++)
            {
                Console.WriteLine("{0}단",x);
                for(int y=1;y<=9;y++)
                {
                    int z = x * y;
                    Console.WriteLine("{0}*{1}={2}",x,y,z);
                }
            }
            //별삼각형
            for(int s=1;s<=10;s++)
            {
                for(int e=10;e>=s;e--)
                {
                    Console.Write("★");
                }
                Console.Write("\n");
            }

        }
    }
}
