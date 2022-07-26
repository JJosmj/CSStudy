using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Linq 실습하기 교재 525
 * 
 * Linq
 * - Linq(Languge Intergrated Querry)는 컬렉션을 대상으로 데이터를 처리하기 위한 C# 질의언어
 * - Linq를 사용해서 DB와 함꼐 데이터를 쉽게 관리
 */
namespace Ch09
{
    class Member
    {
        private string uid;
        private string name;
        private int age;

        public Member(string uid, string name, int age)
        {
            this.uid = uid;
            this.name = name;
            this.age = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }


    internal class _3_Linq
    {
        static void Main(string[] args)
        {
            //켈렉션 생성
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //결과 리스트 생성
            List<int> rslist1 = new List<int>();
            List<int> rslist2 = new List<int>();

            //for문 이용한 짝수 추출
            foreach(int i in list)
            {
                if(i % 2 == 0)
                {
                    rslist1.Add(i);
                }
            }

            //람다식을 이용한 짝수 추출
            list.ForEach((n) => {
                if (n % 2 == 0)
                {
                    rslist2.Add(n);
                }
            });


            //Linq를 이용한 짝수 추출
            var rslist3 =   from n in list
                            where n % 2 == 0
                            select n;

            Console.WriteLine("rslist1: " +string.Join(",",rslist1));
            Console.WriteLine("rslist2: " +string.Join(",",rslist2));
            Console.WriteLine("rslist3: " +string.Join(",",rslist3));

            //데이터가 5이상 큰 순서대로 추출
            var rslist4 = from n in list
                          where n >= 5
                          orderby n descending
                          select n;

            Console.WriteLine("relist4: " + string.Join(",",rslist4));

            //Linq 객체 리스트 활용
            List<Member> members = new List<Member>();
            members.Add(new Member("a101", "김유신", 25));
            members.Add(new Member("a102", "김춘추", 23));
            members.Add(new Member("a103", "장보고", 35));
            members.Add(new Member("a104", "강감찬", 45));
            members.Add(new Member("a105", "이순신", 55));

            //30세 이상,이름,사전 순 추출
            var rslist5 = from m in members
                          where m.Age >= 30
                          orderby m.Name ascending
                          select m;

            foreach(Member m in rslist5)
            {
                Console.WriteLine("{0},{1},{2}", m.Uid,m.Name,m.Age);
            }






        }
    }
}
