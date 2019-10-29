using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 656p 예제 */
namespace Task05_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메인 A");
            Console.WriteLine("메인 B");

            MyMethodAsync(3);

            Console.WriteLine("메인 E");
            Console.WriteLine("메인 F");
            Console.Read();
        }

        async private static void MyMethodAsync(int count)
        {
            Console.WriteLine("메인 C");
            Console.WriteLine("메인 D");

            await Task.Run(()=> 
            {
                for (int i = 0; i < count; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{i}/{count}");
                }
            });

            Console.WriteLine("메인 G");
            Console.WriteLine("메인 H");
        }
    }
}
