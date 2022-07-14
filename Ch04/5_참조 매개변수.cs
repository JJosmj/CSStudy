using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 메서드 참조 매개변수 실습하기 p256
 * 
 * 
 */
namespace Ch04
{
    internal class _5_참조_매개변수
    {
        static void Main(string[] args)
        {

            int n1 = 10;
            int n2 = 3;
            int n3 = 0;
            int n4 = 0;

            MyDivider(n1, n2, ref n3, ref n4);
            Console.WriteLine("몫:{0},나머지{1}",n3,n4);
        


        }//end of Main

        public static void MyDivider(int a1,int a2, ref int a3, ref int a4)
        {
            a3 = a1 / a2;
            a4 = a1 % a2;

        }
    }
}
