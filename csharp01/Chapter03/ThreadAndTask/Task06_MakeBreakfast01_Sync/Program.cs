using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task06_MakeBreakfast01_Sync
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
        static void Main(string[] args)
        {
            Console.WriteLine("***** 아침 식사 준비 시작 *****\n");

            DateTime startTime = DateTime.Now;

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");
            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");
            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            Console.WriteLine("Breakfast is ready!");
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // 두 날짜 사이의 시간 간격 저장
            Console.WriteLine($"실행 시간: {elapsed}");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("오렌지 주스를 따른다.");
            Thread.Sleep(1000);
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

        private static Toast ToastBread(int count)
        {
            Console.WriteLine("토스트 준비");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"토스트 빵 굽기 {i}");
                Thread.Sleep(1000);
            }
            return new Toast();
        }

        private static Bacon FryBacon(int count)
        {
            Console.WriteLine("베이컨 준비");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"베이컨 만들기 {i}");
                Thread.Sleep(1000);
            }
            return new Bacon();
        }

        private static Egg FryEggs(int count)
        {
            Console.WriteLine("계란 준비");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"계란 후라이 만들기 {i}");
                Thread.Sleep(1000);
            }
            return new Egg();
        }
    }


}
