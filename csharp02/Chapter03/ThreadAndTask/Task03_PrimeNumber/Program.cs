using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 649p 예제 */
// 소수를 구하는 과정을 여러 비동기 작업으로 나누어 처리
namespace Task03_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 소수를 판별 숫자 범위
            long startNum = 2, endNum = 10000;
            int taskCount = 8;

            // 각각의 Task가 수행할 메소드 준비
            Func<object, List<long>> FindPrimeFunc = (objRange) => {
                long[] range = (long[])objRange;  // 소수 탐색 범위를 저장한 배열
                List<long> foundList = new List<long>();  // 찾은 소수를 저장할 배열

                // 소수를 찾으면  foundList에 추가
                for (long i = range[0]; i < range[1]; i++)
                {
                    if (IsPrime(i))
                        foundList.Add(i);
                }
                return foundList;
            };

            // 태스크를 저장할 배열 생성
            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];

            // 태스크별 작업범위 중 첫 번째
            long currentStartNum = startNum;          // 2
            long currentEndNum = endNum / taskCount;  // 10000/4 = 2500

            // 다른 모든 태스크의 작업범위 지정 및 인스턴스 생성
            for (int i = 0; i < taskCount; i++)  // 0~3 
            {
                Console.WriteLine($"Task[{i}] : {currentStartNum} ~ {currentEndNum}");
                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentStartNum, currentEndNum });

                // 다음 작업 준비
                currentStartNum = currentEndNum + 1;  // 2500 + 1 => 2501
                currentEndNum = currentEndNum + (endNum / taskCount); // 2500 + (10000/4) => 5000
            }

            Console.WriteLine("Started....");
            DateTime startTime = DateTime.Now;

            // 모든 비동기 작업 실행
            foreach (var task in tasks)
                task.Start();

            // 모든 작업 결과를 통합할 리스트
            List<long> totalPrimeNumberList = new List<long>();

            // 모든 비동기 작업이 끝날 때까지 기다렸다가 totalPrimeNumberList에 결과 통합
            foreach (var task in tasks)
            {
                task.Wait();
                totalPrimeNumberList.AddRange(task.Result);
            }
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;
            Console.WriteLine($"소수 개수: {totalPrimeNumberList.Count}");
            Console.WriteLine($"실행 시간: {elapsed}");
        }

        private static bool IsPrime(long num)
        {
            if (num == 2) return true;
            for (long i = 2; i <= num/2 ; i++)
            {
                if (num % i == 0) 
                    return false;
            }
            return true;
        }
    }
}
