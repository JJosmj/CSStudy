﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class _94
    {
        static void Main1(string[] args)
        {
            int n = 10;

            //뒤
            Console.WriteLine(n);
            Console.WriteLine(n++);
            Console.WriteLine(n--);
            Console.WriteLine(n);

            //앞
            Console.WriteLine(n);
            Console.WriteLine(++n);
            Console.WriteLine(--n);
            Console.WriteLine(n);
        }

    }
}
