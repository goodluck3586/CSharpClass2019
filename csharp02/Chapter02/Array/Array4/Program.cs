using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 가변 배열 (다양한 길이의 배열을 요소로 갖는 배열) */
namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 6, 7, 8 };
            jagged[2] = new int[] { 9, 10 };

            PrintArray(jagged);

            // 가변배열 초기화 방법
            int[][] jagged2 = new int[2][]
            {
                new int[5] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8 }
            };
        }

        private static void PrintArray(int[][] jagged)
        {
            foreach (var arr in jagged)
            {
                Console.Write($"Length({arr.Length}) : ");
                foreach (var item in arr)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
