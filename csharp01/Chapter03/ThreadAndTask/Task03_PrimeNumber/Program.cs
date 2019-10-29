using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 649p 예제 */
namespace Task03_PrimeNumber
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
            long startNum=2, endNum=100000; // 1~2500, 2501~5000, 5001~7500, 7501~10000
            int taskCount = 8;  // Task 숫자

            // 넘겨받은 범위의 숫자에서 소수를 찾아 found 리스트에 담아 반환하는 함수
            Func<object, List<long>> FindPrimeFunc = (objRange) =>
            {
                long[] range = (long[])objRange;
                List<long> found = new List<long>();  // 찾은 소수를 저장할 리스트

                for (long i = range[0]; i < range[1]; i++)
                {
                    if (IsPrime(i))
                        found.Add(i);
                }
                return found;
            };

            // Task 배열
            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];

            // Task별 작업 숫자 범위 지정(첫 번째 태스크에게 줄 범위)
            long currentStartNum = startNum;  // 2
            long currentEndNum = endNum / taskCount;  // 10000 / 4

            // 두 번째 Task부터 마지막 Task까지 숫자 범위 지정
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine($"Task[{i}] : {currentStartNum} ~ {currentEndNum}");
                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentStartNum, currentEndNum });
                
                currentStartNum = currentEndNum + 1;
                currentEndNum = currentEndNum + (endNum / taskCount);  // 10000/4 = 2500
            }

            Console.WriteLine("Started....");
            DateTime startTime = DateTime.Now;  // 소수 판별을 시작한 시간 저장

            // Task 모두 실행
            foreach (var task in tasks)
                task.Start();

            List<long> totalList = new List<long>();

            // 모든 작업이 종료되면 totalList로 합친다.
            foreach (var task in tasks)
            {
                task.Wait();  // 모든 작업이 끝날 때 까지 기다림.
                totalList.AddRange(task.Result);  // 리스트에 리스트를 합치는 작업
            }
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;  // TimeSpan은 두 날짜 간의 시간 간격을 저장
            Console.WriteLine($"{startNum} ~ {endNum} 소수 개수 = {totalList.Count}");
            Console.WriteLine($"실행 시간: {elapsed}");
        }
    }
}
