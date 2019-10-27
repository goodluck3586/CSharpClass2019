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
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoSomething);
            Console.WriteLine("Start Thread....");
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(100);
            }

            Console.WriteLine("스레드가 종료될 때 까지 대기");
            t1.Join();
        }

        private static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(100);
            }
        }
    }
}
