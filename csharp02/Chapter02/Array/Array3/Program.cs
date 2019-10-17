using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2차원 배열 */
namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            PrintArr(arr1);
        }

        static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)  // .GetLength(0) 1차원 : 2
            {
                for (int j = 0; j < arr.GetLength(1); j++)  // .GetLength(1) 2차원 : 3
                {
                    Console.Write($"[{i}, {j}] : {arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
