using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 컬렉션 리스트 실습하기 교재 211
 * 
 * 리스트(List)
 * - 배열과 유사한 선형자료구조로 배열과 다르게 동적으로 데이터를 처리
 * - ArrayList 일반화 시켜 더나은 성능을 가진 List를사용
 */
namespace Ch07
{
    internal class _3_List
    {
        static void Main1(string[] args)
        {
            ///////////////////////////
            ///ArrayList
            //////////////////////////
            
            //ArrayList 생성
            ArrayList arrlist1 = new ArrayList();

            //데이터 추가
            arrlist1.Add(1);
            arrlist1.Add(2);
            arrlist1.Add(3);
            arrlist1.Add(4);
            arrlist1.Add(5);

            //데이터 삽입
            arrlist1.Insert(1, 6);

            //데이터 삭제
            arrlist1.Remove(6);
            arrlist1.RemoveAt(0);

            //데이터 출력
            foreach(int n in arrlist1)
            {
                Console.Write(n+" ");
               
            }
            Console.WriteLine( );

            //다양한 타입의 데이터를 갖는 ArrayList
            ArrayList arraylist2 = new ArrayList();
            arraylist2.Add(1);
            arraylist2.Add(1.23);
            arraylist2.Add(true);
            arraylist2.Add('A');
            arraylist2.Add("Apple");

            for(int i = 0; i < arraylist2.Count; i++)
            {
                Console.Write(arraylist2[i]+" ");
            }
            Console.WriteLine();


            //////////////////////////
            ///List
            /////////////////////////
            
            //List 생성
            List<int> list1 = new List<int>();

            //데이터 추가
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            //데이터 삽입
            list1.Insert(1, 6);

            //데이터 삭제
            list1.Remove(4);
            list1.RemoveAt(1);

            foreach(int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            List<string> list2 = new List<string>();
            list2.Add("서울");
            list2.Add("대전");
            list2.Add("대구");
            list2.Add("부산");
            list2.Add("광주");

            foreach(string n in list2)
            {
                Console.Write(n+ " ");
            }
            Console.WriteLine();

            //객체 리스트
            List<Apple> list3 = new List<Apple>();

            list3.Add(new Apple("한국", 3000));
            list3.Add(new Apple("미국", 2000));
            list3.Add(new Apple("일본", 1000));

            Apple apple = list3[0];
          

            apple.Show();
            list3[1].Show();
            list3[2].Show();
        }
    }
}
