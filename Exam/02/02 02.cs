using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class _02_02
    {
        static void Main1(string[] args)
        {
            int[] arr = { 17, 92, 18, 33, 58, 7, 26, 42 };
            int m= arr[0];
            int n= 0;

            for(int i=0;i<8;i++)
            {
                if(m < arr[i])
                {
                    m = arr[i];
                  
                }

                if(n < arr[i])
                {
                    n = arr.Min();
                }
            }
            Console.WriteLine("배열 arr에서 가장 큰수: "+m);
            Console.WriteLine("배열 arr에서 가장 작은수: "+n);
        }
    }
}
