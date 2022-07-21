using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    class customer
    {
        protected int id;
        protected string name;
        protected string grade;
        protected double point;
        protected double pointratio;

        public customer(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.grade = "SIVER";
            this.point = 100;
            this.pointratio = 0.01;
        }
        public virtual int CalcPrice(int price)
        {
            point += price * pointratio;
            return price;
        }

        public void ShowInfo()
        {
            Console.WriteLine("===============");
            Console.WriteLine("고객번호: "+ id);
            Console.WriteLine("고객이름: "+ name);
            Console.WriteLine("고객등급: "+ grade);
            Console.WriteLine("현재 포인트: "+ point);
            Console.WriteLine("포인트 적립율: "+ pointratio);
            Console.WriteLine("---------------");
        }
    }

    class VipCustomer : customer
    {
        private double saleRatio;
        public VipCustomer(int id, string name ) :base(id, name)
        {
            base.grade = "VIP";
            base.point = 1000;
            base.pointratio = 0.05;
            this.saleRatio = 0.1;
        }
        public override int CalcPrice(int price)
        {
            point += price * pointratio;
            return price - (int)(price*saleRatio);
        }

    }

    internal class _03_07
    {
        static void Main1(string[] args)
        {
            customer kim = new customer (1001, "김춘추");
            VipCustomer lee = new VipCustomer (1002, "이순시");

            Console.WriteLine("김춘추님이 지불할 금액: " + kim.CalcPrice);
            Console.WriteLine("이순신님이 지불할 금액: " + lee.CalcPrice);

            kim.ShowInfo();
            lee.ShowInfo();

        }
    }
}
