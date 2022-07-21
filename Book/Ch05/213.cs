using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class _213
    {
        static void Main1(string[] args)
        {
            //변수 선언
            List<int> list = new List<int>();

            //리스트에 요소를 추가
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            //반복을 수행
            foreach(var item in list)
            {
                Console.WriteLine("Count: " +list.Count+"\ntitem:" + item);
            }
        }
    }
}
