using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 인덱서 실습하기 교재 398
 * 
 * 인덱서(Indexer)
 * - 객체를 배열처럼 인덱스를 활용해서 객체의 속성을 참조 할 수 있게 해주는 속성
 * -인덱서를 메서드로 대체 가능
 */
namespace Ch06
{
    class MyArray
    {
        private int[] array;

        public MyArray()
        {
            array = new int[3];
        }

        public int this[int i]
        {
            get { return array[i]; }
            set
            {
                if (i < array.Length)
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("더 이상 데이터를 저장할 수 없습니다.");
                }
            }
        }
    }

    internal class _5_인덱서
    {
        static void Main1(string[] args)
        {
            MyArray mArr = new MyArray();
            mArr[0] = 100;
            mArr[1] = 200;
            mArr[2] = 300;
            mArr[3] = 400;
            

            for(int i= 0;i<3;i++)
            {
                Console.Write(mArr[i]+" ");
            }
        }
    }
}
