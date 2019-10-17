using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ06
{
    class Program
    {
        // 랜덤 숫자 생성 메서드
        static int[] GenerateRandomIntegerNum(int length)
        {
            int[] numbers = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            // 1. 데이터 소스(자연수 20개를 저장한 배열)
            int[] numbers = GenerateRandomIntegerNum(20);

            #region Query 구문 사용
            PrintArr(numbers);   // 배열의 초기 상태 출력

            // 2. 쿼리 만들기(짝수만 오름차순 정렬하는 쿼리)
            var numList1 = from num in numbers
                           where num % 2 == 0
                           orderby num
                           select num;

            // 3. 쿼리 실행(출력)
            foreach (var item in numList1)
                Console.Write($"{item} ");
            Console.WriteLine();
            #endregion

            #region Methdo 구문 사용
            // 2. 메서드로 쿼리 만들기
            var numList2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            // 3. 쿼리 실행(출력)
            foreach (var item in numList2)
                Console.Write($"{item} ");
            Console.WriteLine();
            #endregion

            int itemCount = (from num in numbers
                           where num % 2 == 0
                           orderby num
                           select num).Count();
            Console.WriteLine(itemCount);

            double itemAvg = (from num in numbers
                             where num % 2 == 0
                             orderby num
                             select num).Average();
            Console.WriteLine(itemAvg);
        }

        private static void PrintArr(int[] numbers)
        {
            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
