using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Main Thread 시작 ***");

            // Sub Thread1 생성 및 실행
            Thread t_sub1 = new Thread(new ThreadStart(subThreadFunc1));
            t_sub1.Start();

            // Sub Thread2 생성 및 실행
            Thread t_sub2 = new Thread(new ParameterizedThreadStart(subThreadFunc2));
            t_sub2.Start(50);
            t_sub2.IsBackground = true;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main Thread : {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Main Thread 종료");

        }

        private static void subThreadFunc2(object count)
        {
            Console.WriteLine("*** SubThread2 시작 ***");
            for (int i = 0; i < (int)count; i++)
            {
                Console.WriteLine($"Sub Thread2 : {i}");
                Thread.Sleep(1000);
            }
        }

        private static void subThreadFunc1()
        {
            Console.WriteLine("*** SubThread1 시작 ***");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Sub Thread1 : {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
