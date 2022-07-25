using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2022/7/25
 * 조민제
 * 컬렉션 스택 실습하기
 * 
 * 큐(Queue)
 * -가장 기본적인 자료구조
 * -먼저 입력된 데이터가 먼저 출력되는 선형구조(FIFO:선입선출)
 * -다향한 알고리즘 및 함수 호출에 사용
 */
namespace Ch07
{
    internal class _2_Queue
    {
        static void Main1(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("김유신");
            queue.Enqueue("김춘추");
            queue.Enqueue("장보고");
            queue.Enqueue("강감찬");
            queue.Enqueue("이순신");

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
