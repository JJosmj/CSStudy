﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p147
    {
        static void Main1(string[] args)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽 이동");
                    break ;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽 이동");
                    break ;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래 이동");
                    break;
                    default: Console.WriteLine("다른키");
                    break;

            }
        }
    }
}
