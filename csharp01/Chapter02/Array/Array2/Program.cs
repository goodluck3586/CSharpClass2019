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
            int[] scores = new int[] { 80, 90, 95, 35, 70 };
            PrintArray(scores);

            // 정렬
            Array.Sort(scores);
            PrintArray(scores);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // 배열의 차원
            Console.WriteLine($"{scores.Rank}");  // 1차원
            int[,] testArray = new int[4,5];
            Console.WriteLine($"{testArray.Rank}");  // 2차원

            // 탐색
            Console.WriteLine($"이진 탐색: 90 is at {Array.BinarySearch(scores, 90)}");  
            Console.WriteLine($"순차 탐색: 90 is at {Array.IndexOf(scores, 90)}");

            // 조건 검색
            Console.WriteLine("모든 요소가 통과? {0}", Array.TrueForAll(scores, CheckPassed));

            // 배열에서 조건을 만족하는 첫 번째 index 반환
            int index = Array.FindIndex<int>(scores, delegate (int score)
            {
                if (score < 60)
                    return true;
                else
                    return false;
            });
            Console.WriteLine($"index: {index}");
            scores[index] = 60;

            Console.WriteLine("모든 요소가 통과? {0}", Array.TrueForAll(scores, CheckPassed));

            // 배열 크기 재설정
            Console.WriteLine(scores.GetLength(0));  // 0은 1 차원
            Array.Resize(ref scores, 10);
            Console.WriteLine(scores.GetLength(0));  // 0은 1 차원
            PrintArray(scores);

            // 배열 초기화
            Array.Clear(scores, 0, scores.Length - 1);
            PrintArray(scores);
        }


        static void PrintArray(int[] array)
        {
            foreach(int i in array)
                Console.Write($"{i} ");
            Console.WriteLine('\n');
        }

        static void Print(int i)
        {
            Console.Write($"{i} ");
        }

        static bool CheckPassed(int score)
        {
            return (score >= 60) ? true : false;
        }
    }
}
