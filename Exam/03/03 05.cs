using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    class vehicle
    {
        private string name;
        private int price;

        public vehicle(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine("==========");
            Console.WriteLine("차량명" + name);
            Console.WriteLine("가격: " + price);
            Console.WriteLine("----------");
        }
    }

    class CarFactory
    {
        private static CarFactory instance= new CarFactory();
        private CarFactory() { }

        public static CarFactory Instance
        { get { return instance; } }

        public vehicle MakeCar(string name, int price)
        {
            return new vehicle(name, price);
        }
    }
    internal class _03_05
    {
        static void Main1(string[] args)
        {
            CarFactory factory = CarFactory.Instance;

            vehicle avante = factory.MakeCar("아반테", 2500);
            vehicle sonata = factory.MakeCar("소나타", 3000);

            avante.Show();
            sonata.Show();

        }

    }
}
