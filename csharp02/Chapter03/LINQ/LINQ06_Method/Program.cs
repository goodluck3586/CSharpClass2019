using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 표준 쿼리 연산자: 사용자는 쿼리 구문 대신 메소드 구문을 사용할 수 있다. */
namespace LINQ06_Method
{
    class Program
    {
        // 랜덤 자연수 20개 생성 함수
        static int[] GenerateRandomIntegerNumbers(int length)
        {
            Random random = new Random();
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            // 1. 데이터 소스(자연수 20개를 가진 배열)
            int[] numbers = GenerateRandomIntegerNumbers(20);

            // numbers 배열의 초기상태 출력
            PrintArray(numbers);

            #region LINQ 쿼리 구문 사용
            // 2. 쿼리 만들기(짝수만 오름차순으로 남기기)
            var evenNumList = from num in numbers
                              where num % 2 == 0
                              orderby num ascending
                              select num;

            // 3. 쿼리 실행(출력)
            foreach (var item in evenNumList)
                Console.Write($"{item} ");
            Console.WriteLine();
            #endregion

            #region LINQ 메소드 구문 사용
            // 2. 메서드로 쿼리 만들기
            var evenNumList2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

            // 3. 쿼리 실행(출력)
            foreach (var item in evenNumList2)
                Console.Write($"{item} ");
            Console.WriteLine();
            #endregion

            int count = (from num in numbers
                         where num % 2 == 0
                         orderby num ascending
                         select num).Count();
            Console.WriteLine(count);

            double avg = (from num in numbers
                          where num % 2 == 0
                          orderby num ascending
                          select num).Average();
            Console.WriteLine(avg);

            List<int> list = (from num in numbers
                              where num % 2 == 0
                              orderby num ascending
                              select num).ToList();
        }

        private static void PrintArray(int[] numbers)
        {
            Console.WriteLine("배열의 초기상태");
            foreach (var item in numbers)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
