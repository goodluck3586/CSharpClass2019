using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 611p 예제 */
namespace Thread02
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                //Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoSomething);
            Console.WriteLine("Starting thread1...");
            t1.Start();

            Thread t2 = new Thread(DoSomething);
            Console.WriteLine("Starting thread2...");
            t2.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"MainThread : {i}");
                //Thread.Sleep(10);
            }

            // 모든 스레드가 종료될 때까지 기디림
            t1.Join();
            t2.Join();

            Console.WriteLine("메인 스레드 종료");
        }
    }
}
