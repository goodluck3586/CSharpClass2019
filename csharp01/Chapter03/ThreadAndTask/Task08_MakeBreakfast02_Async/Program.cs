using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task08_MakeBreakfast02_Async
{
    internal class Toast
    {
    }
    internal class Bacon
    {
    }
    internal class Egg
    {
    }
    internal class Juice
    {
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("***** 아침 식사 준비 시작 *****\n");

            DateTime startTime = DateTime.Now;

            Task<Egg> eggsTask = FryEggs(10);
            var baconTask = FryBacon(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            #region Task.WhenAll
            //await Task.WhenAll(eggsTask, baconTask, toastTask);
            //Console.WriteLine("eggs are ready");
            //Console.WriteLine("bacon is ready");
            //Console.WriteLine("toast is ready");
            //Juice oj = PourOJ();
            //Console.WriteLine("oj is ready");
            #endregion

            var allTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finished == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finished == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }
                allTasks.Remove(finished);
            }
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");

            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // 두 날짜 사이의 시간 간격 저장
            Console.WriteLine($"실행 시간: {elapsed}");
        }

        async static Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
        }

        async static Task<Toast> ToastBreadAsync(int number)
        {
            Console.WriteLine("토스트빵 준비");

            await Task.Run(() => {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine($"토스트 빵 굽기 {i}");
                    Thread.Sleep(1000);
                }
            });
            return new Toast();
        }

        async private static Task<Egg> FryEggs(int count)
        {
            Console.WriteLine("계란 준비");

            await Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"계란 후라이 만들기 {i}");
                    Thread.Sleep(1000);
                }
            });

            return new Egg();
        }

        async private static Task<Bacon> FryBacon(int count)
        {
            Console.WriteLine("베이컨 준비");

            await Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"베이컨 만들기 {i}");
                    Thread.Sleep(1000);
                }
            });

            return new Bacon();
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("오렌지 주스를 따른다.");
            Thread.Sleep(1000);  // new Random().Next(1000, 2000)
            return new Juice();
        }

        private static void ApplyJam(Toast toast)
        {
            Console.WriteLine("빵에 잼을 바른다.");
            Thread.Sleep(1000);
        }

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("빵에 버터를 바른다.");
            Thread.Sleep(1000);
        }
    }
}