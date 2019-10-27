using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 652p 예제 */
namespace Task04_Parallel
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if (number == 2)
                return true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            // 소수를 판별할 범위
            long startNum = 2, endNum = 100000; // 1~2500, 2501~5000, 5001~7500, 7501~10000
            Console.WriteLine("Started....");
            DateTime startTime = DateTime.Now;  // 소수 판별을 시작한 시간 저장
            List<long> totalList = new List<long>();  // 소수를 저장할 리스트

            Parallel.For(startNum, endNum, (long i) =>
            {
                lock (totalList)
                {
                    if (IsPrime(i))
                        totalList.Add(i);
                } 
            });

            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // TimeSpan은 두 날짜 간의 시간 간격을 저장
            Console.WriteLine($"{startNum} ~ {endNum} 소수 개수 = {totalList.Count}");
            Console.WriteLine($"실행 시간: {elapsed}");

        }
    }
}
