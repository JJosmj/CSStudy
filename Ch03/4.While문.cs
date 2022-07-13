using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 반복문 While 실습하기 교재 p162
 * 
 */
namespace Ch03
{
    internal class _4
    {
        static void Main1(string[] args)
        {
            //While
            int sum=0;
            int k = 1;
            
            while(k<=0)
            {
                sum += k;
                k++;
               
            }
            Console.WriteLine("1부터 10까지 합"+sum);

            //do~While :최초 한번 반복수행
            int total = 0;
            int i = 1;
            do
            {
                if(i% 2 == 0)
                {
                    total += 1;
                }
                total += 1;
                i++;
                
            }
            while (i <= 10);
            {

            }
            Console.WriteLine("1부터 10까지 짝수 합" + total);

            //break
            int n = 1;
            while(true)
            {
                if(n % 5 == 0 && n % 7 ==0)
                {
                    break;
                }
                n++;
            }
            Console.WriteLine("5와7읠 최소공배수:" +n);

            //continue
            int o = 0;
            int s = 0;

            while(n<=10)
            {
                s++;

                if(n%2==1)
                {
                    //홀수이면 반복문의 처음으로 이동
                    continue;  
                }
                    //짝수이면
                o += s;
            }
            Console.WriteLine("1부터 10까지 짝수합:"+o);
        }
    }
}
