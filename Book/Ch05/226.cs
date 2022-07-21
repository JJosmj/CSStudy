using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class _226
    {
        class Product
        {
            public string Name;
            public int price;
        }
        static void Main1(string[] args)
        {
            //인스턴스 생성
            Product product = new Product();

            //인스턴스 변수 변경
            product.Name = "감자";
            product.price = 2000;

            //인스턴스 변수 출력
            Console.WriteLine(product.Name + ":" + product.price + "원");
        }
    }
}
