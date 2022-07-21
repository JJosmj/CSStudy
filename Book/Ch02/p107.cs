using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p107
    {
        static void Main1(string[] args)
        {
            //Long 자료형을 int 자료형으로 변환
            long longnumber = 2147483647L + 2147483647L;
            int intnumber = (int)longnumber;
            Console.WriteLine(intnumber);
        }
    }
}
