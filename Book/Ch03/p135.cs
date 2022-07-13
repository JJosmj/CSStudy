using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p135
    {
        static void Main1(string[] args)
        {
            if(DateTime.Now.Hour<11)
            {
                Console.WriteLine("아침먹을시간");
            }
            else if(DateTime.Now.Hour<15)
            {
                Console.WriteLine("점심냠냠");
            }
            else
            {
                Console.WriteLine("저념");
            }
        }
    }
}
