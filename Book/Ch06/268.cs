using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class _268
    {
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print 메서드가 호출");
            }
        }

        static void Main1(string[] args)
        {
            Test test = new Test();
            test.Print();
            test.Print();
            test.Print();
        }
    }
}
