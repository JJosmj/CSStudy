using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    class Car
    {
        private string comapny;
        private string name;
        private int price;

        public  Car(string comapny, string name, int price)
        {
            this.comapny = comapny;
            this.name = name;
            this.price = price;
        }
        private void Drive()
        {
            Console.WriteLine(name + "운행 중...");
        }
        public void Show()
        {
            Drive();
            Console.WriteLine("제조사: "+comapny);
            Console.WriteLine("차량명: "+name);
            Console.WriteLine("가격: "+price);
            Console.WriteLine();
        }

    }


    internal class _03_03
    {
        static void Main1(string[] args)
        {
            Car sonata;
            Car bmw;

            sonata = new Car("현대","소나타",3000);
            bmw = new Car("bmw","520d",5000) ;

            sonata.Show();
            bmw.Show();
        }
    }
}
