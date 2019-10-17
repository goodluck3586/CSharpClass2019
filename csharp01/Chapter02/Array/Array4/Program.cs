using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 가변 배열 */
namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 6, 7, 8 };
            jagged[2] =new int[] {9, 10};
            PrintArr(jagged);

            // 선언과 동시에 초기화
            int[][] jagged2 = new int[2][]
            {
                new int[]{10, 20, 30},
                new int[]{40, 50}
            };
            PrintArr(jagged2);

        }

        private static void PrintArr(int[][] jagged)
        {
            foreach(int[] arr in jagged)
            {
                Console.Write($"Length({arr.Length}) : ");
                foreach(int e in arr)
                    Console.Write($"{e} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
