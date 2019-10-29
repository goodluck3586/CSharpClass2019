using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            // 소수를 판별 숫자 범위
            long startNum = 2, endNum = 100000;

            Console.WriteLine("Started....");
            DateTime startTime = DateTime.Now;
            List<long> totalPrimeNumberList = new List<long>();

            Parallel.For(startNum, endNum, (long i) =>
            {
                lock (totalPrimeNumberList)
                {
                    if (IsPrime(i))
                        totalPrimeNumberList.Add(i);
                }
            });

            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // 날짜 사이의 경과된 시간 저장
            Console.WriteLine($"소수 개수: {totalPrimeNumberList.Count}");
            Console.WriteLine($"실행 시간: {elapsed}");
        }

        private static bool IsPrime(long num)
        {
            if (num == 2) return true;
            for (long i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
