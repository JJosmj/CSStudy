using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _159
    {
        static void Main1(string[] args)
        {
            //배열을 생성
            int[] intArray = { 52, 273, 32, 65, 103 };

            //배열의 요소 변셩
            intArray[0] = 0;

            //요소 출력
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
        }
    }
}
