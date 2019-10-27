using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 매개변수가 있는 스레드 */
namespace Thread03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수값 하나를 전달받는 스레드 메소드 호출
            Thread t1 = new Thread(threadFunc1);
            t1.Start(6);  

            // 두 개 이상의 값을 저장한 객체를 전달받는 스레드 메소드 호출
            NameCard nc = new NameCard() { Name = "아이유", Age = 28 };
            Thread t2 = new Thread(threadFunc2);
            t2.Start(nc);
        }

        private static void threadFunc2(object obj)
        {
            NameCard nameCard = obj as NameCard;
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{nameCard.Name}, {nameCard.Age}");
            }
            
        }

        private static void threadFunc1(object count)
        {
            for (int i = 0; i < (int)count; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"threadFunc1() : {i}");
            }
        }
    }
}
