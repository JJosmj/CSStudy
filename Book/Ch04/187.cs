using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace Book.Ch04
{
    internal class _187
    {
        static void Main1(string[] args)
        {
            int x = 1;
            while(x<50)
            {
                //화면을 지우고 커서 이동
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                //출력
                if(x % 3==0)
                    Console.WriteLine("__@");
                else if (x % 3==1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                //100ms 정지 x 증가
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
