using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* LINQ(Language Intergrated Query */
/* 컬렉션을 핸들링하는 기능 */
namespace LINQ01
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

            /* numbers 배열에서 짝수만 추출하여 새로운 List에 저장하고 출력 */
            #region LINQ를 사용하지 않은 경우
            // numbers 배열의 초기상태 출력
            PrintArray(numbers);

            // 1. 짝수만 저장할 List 생성
            List<int> numList = new List<int>();

            // 2. numbers 배열에서 짝수만 추출하여 List에 저장
            foreach (var num in numbers)
            {
                if (num % 2 == 0) numList.Add(num);
            }

            // 3. List의 숫자들을 오름차순 정럴
            numList.Sort();

            // 4. List 출력
            foreach (var item in numList)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
            #endregion

            #region LINQ를 사용한 경우
            // numbers 배열의 초기상태 출력
            PrintArray(numbers);

            // 1. 쿼리 만들기(짝수만 오름차순으로 남기는 쿼리)
            var linqList = from num in numbers  // num(임시 변수), numbers(컬렉션)
                           where num % 2 == 0  // true인 요소만 반환(필터링)
                           orderby num         // num이 정렬의 기준
                           select num;         // 추출할 대상 지정

            // 2. 쿼리 실행(출력)
            foreach (var item in linqList)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
            #endregion

            #region LINQ를 사용한 경우(2와 3으로 나뉘는 요소만 추출)
            // numbers 배열의 초기상태 출력
            PrintArray(numbers);

            // 1. 쿼리 만들기(2와 3으로 나뉘는 숫자를 오름차순으로 남기는 쿼리)
            var linqList2 = from num in numbers  // num(임시 변수), numbers(컬렉션)
                           where num % 2 == 0 && num % 3 == 0  // true인 요소만 반환(필터링)
                           orderby num         // num이 정렬의 기준
                           select num;         // 추출할 대상 지정

            // 2. 쿼리 실행(출력)
            PrintLINQList(linqList2);
            #endregion
        }

        private static void PrintLINQList(IOrderedEnumerable<int> linqList2)
        {
            foreach (var item in linqList2)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
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
