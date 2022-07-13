using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _163
    {
        static void Main1(string[] args)
        {
            //변수를 선언
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            //반복을 수행
            while(i < intArray.Length)
            {
                //출력
                Console.WriteLine(i+"번째 출력:" + intArray[i]);
                //탈출 변수
                i++;
            }
        }
    }
}
