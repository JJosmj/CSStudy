using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _176
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<10-i;j++)
                    Console.Write(' ');
                for(int k=0;k<i+1;k++)
                    Console.Write('*');
                Console.Write('\n');
            }
        }
    }
}
