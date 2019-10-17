using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* System.Array 활용 */
namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 80, 70, 90, 35, 65 };
            PrintArray(scores);

            Array.Sort(scores);  // 정렬
            PrintArray(scores);

            // 배열의 각 요소에 대해 특정 함수 실행
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // 배열의 차원
            Console.WriteLine($"{scores.Rank} 차원");
            int[,] scores2 = new int[3,4];
            Console.WriteLine($"{scores2.Rank} 차원");

            // 탐색
            Console.WriteLine(Array.BinarySearch<int>(scores, 80));  // 이진 탐색
            Console.WriteLine(Array.IndexOf<int>(scores, 80));  // 순차 탐색

            Console.WriteLine(Array.TrueForAll<int>(scores, CheckPassed));  // 모든 요소가 60이상인가?
            int index = Array.FindIndex<int>(scores, delegate(int score)
            {
                return (score < 60) ? true : false;
            });
            Console.WriteLine($"index: {index}");
            scores[index] = 60;
            Console.WriteLine(Array.TrueForAll<int>(scores, CheckPassed));  // 모든 요소가 60이상인가?

            // 배열의 크기 재설정
            Console.WriteLine($"scores 배열의 크기 : {scores.GetLength(0)}");  // 0은 1차원
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"scores 배열의 크기 : {scores.GetLength(0)}");

            // 배열 초기화
            PrintArray(scores);
            Array.Clear(scores, 0, scores.Length-1);
            PrintArray(scores);
        }

        // 배열의 모든 요소 출력
        static void PrintArray(int[] array)
        {
            foreach(int score in array)
                Console.Write($"{score} ");
            Console.WriteLine();
        }

        static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static bool CheckPassed(int score)
        {
            return (score >=60) ? true : false;
        }
    }
}
