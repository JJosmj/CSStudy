using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2022/7/21
 * 조민제
 * 제네릭 실습하기 교재 395
 * 
 * 제네릭(Generic)
 * - 클래스 내부의 변수의 타입을 동적으로 일반화 시키는 문법 요소
 * - 제네릭 사용으로 클래스로 범용성 있게 사용한다. 
 */
namespace Ch06
{
    class FruitBox<T>
    {
        private T fruit;
        public FruitBox(T fruit)
        {
            this.fruit = fruit;
        }

        public T Fruit { get => fruit; }

        public T GetFruit()
        {
            return fruit;
        }
    }


    internal class _4_제네릭
    {
        static void Main1(string[] args)
        {
            Apple apple = new Apple("한국", 3000);
            Banana banana = new Banana("대만", 2000);

            FruitBox<Apple> box1 = new FruitBox<Apple>(apple);
            FruitBox<Banana> box2 = new FruitBox<Banana>(banana);

            box1.Fruit.Show();
            box2.GetFruit().Show();


        }
    }
}
