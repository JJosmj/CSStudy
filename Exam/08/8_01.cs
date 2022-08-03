using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._08
{
    internal class _8_01
    {
        static void Main1(string[] args)
        {
            Console.Write("연도입력: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0&&year % 100 != 0)
            {
                Console.WriteLine("{0}은 윤년입니다. ",year);
            }
            else
            {
                Console.WriteLine("{0}은 평년입니다. ", year);
            }
            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0}은 윤년입니다. ", year);
            }
            else
            {
                Console.WriteLine("{0}은 평년입니다. ", year);
            }

        }
    }
}
