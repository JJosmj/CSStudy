using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class _270
    {
        class Test
        {
            public int Miltiply(int min,int max)
            {
                int output = 1;

                for(int i = min; i <= max; i++)
                {
                    output*=i;
                }
                return output;
            }

        }
        static void Main1(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Miltiply(1,10));
        }
    }
}
