using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/07/13
 * 이름 조민제
 * 데이터 령식 변환 실습하기 교재 p106
 * 
 */
namespace Ch02
{
    internal class _5_변환
    {
        static void Main5(string[] args)
        {
            //작은 변수에서 큰 변수
            byte a1 = 255; //1byet
            short a2 = a1; //2byte
            int a3 = a2;   //4byte

            Console.WriteLine("a1 : {0}",a1);
            Console.WriteLine("a2 : {0}",a2);
            Console.WriteLine("a3 : {0}",a3);

            //큰변수 에서 작은변수로 이동
            int a4 = 256;
            short a5 =(short) a4;  //Casting
            byte a6 = (byte)a5;    //Casting

            Console.WriteLine("a4:{0}",a4);
            Console.WriteLine("a5:{0}",a5);
            Console.WriteLine("a6:{0}",a6);

            //정수에서 실수
            int a = 1;
            int b = 3;
            int c= 2;

            double d1 = a;
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1:{0}",d1);
            Console.WriteLine("d2:{0}",d2);
            Console.WriteLine("d3:{0}",d3);

            //실수에서 정수
            double n1 = 1.2;
            double n2 = 2.14;
            double n3 = 12.123;

            int r1 = (int)n1;
            int r2 = (int)n2;
            int r3 = (int)n3;

            Console.WriteLine("r1:",+r1);
            Console.WriteLine("r2:",+r2);
            Console.WriteLine("r3:",+r3);
        }
    }
}
