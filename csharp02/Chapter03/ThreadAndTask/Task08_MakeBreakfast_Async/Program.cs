using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task08_MakeBreakfast_Async
{
    internal class Juice
    {
    }
    internal class Toast
    {
    }
    internal class Bacon
    {
    }
    internal class Egg
    {
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("***** 아침식사 준비 시작 *****");

            Task<Egg> eggsTask = FryEggs(10);
            var baconTask = FryBaconAsync(5);
            var toastTask = MakeToastWithButterAndJamAsync(2);

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
            TimeSpan elapsed = endTime - startTime;
            Console.WriteLine($"준비 시간: {elapsed}");
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
        }

        async private static Task<Egg> FryEggs(int count)
        {
            Console.WriteLine("계란 준비");

            await Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"계란 후라이 만드는 중 {i}");
                    Thread.Sleep(new Random().Next(1000, 2000));
                }
            });

            return new Egg();
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("오렌지 주스를 따른다.");
            Thread.Sleep(new Random().Next(1000, 2000));
            return new Juice();
        }

        private static void ApplyJam(Toast toast)
        {
            Console.WriteLine("토스트빵에 잼을 바른다.");
            Thread.Sleep(new Random().Next(1000, 2000));
        }

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("토스트빵에 버터를 바른다.");
            Thread.Sleep(new Random().Next(1000, 2000));
        }

        private static async Task<Toast> ToastBreadAsync(int count)
        {
            Console.WriteLine("토스트빵 준비");
            await Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"토스트빵 굽는 중 {i}");
                    Thread.Sleep(new Random().Next(1000, 2000));
                }
            });

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int count)
        {
            Console.WriteLine("베이컨 준비");
            await Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"베이컨 만드는 중 {i}");
                    Thread.Sleep(new Random().Next(1000, 2000));
                }
            });

            return new Bacon();
        }


    }
}
