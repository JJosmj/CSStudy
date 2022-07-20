using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * 2022/7/20
 * 조민제
 * 추상 클래스 실습하기 교재 230
 * 
 * 추상클래스(Avstract Class)
 * -공통의 기능은 하나의 메서드로 정의하고 개별적인 기능은 상속받아 override 메서드로 정의하는 추상메서드를갖는 클래스
 * -오직 상속을 목적으로 설계되는 클래스
 */
namespace Ch06
{
    internal class _1_추상_클래스
    {
        //추상클래스는 객채 생성할 수 없음
        //Car car = new Car("소나타","흰색",0);

        static void Main1(string[] args)
        {
            Car sedan = new Sedan("그랜져", "검정", 0, 2000);
            sedan.SpeedUP(100);    
            sedan.SpeedDown(20);
            sedan.Show();

            Car truck = new Truck("검정", "파랑", 0, 1);
            truck.SpeedUP(100);
            truck.SpeedDown(20);
            truck.Show();
        }  
    }
}
