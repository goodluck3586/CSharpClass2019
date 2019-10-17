using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 432p 예제 */
/* 버블소트를 할 때 오름차순, 내림차순 메소드를 매개변수로 전달 */
namespace Delegate04_432p
{
    delegate int Compare(int a, int b);  // 두 값을 비교하여 정수 반환(-1, 0, 1)

    class Program
    {
        // 오름차순 정렬을 위한 체크 메소드: a>b = 1, a==b = 0, a<b = -1
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i, j, temp;
            for (i = 0; i < DataSet.Length-1; i++)
            {
                for (j = 0; j < DataSet.Length-(i+1); j++)
                {
                    if(Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                    PrintArray(DataSet);
                }
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 25, 23, 12, 9, 7 };
            Console.Write("초기 상태 : ");
            PrintArray(array);
            BubbleSort(array, new Compare(AscendCompare));

            int[] array2 = { 25, 23, 12, 9, 7 };
            Console.Write("초기 상태 : ");
            PrintArray(array2);
            BubbleSort(array2, new Compare(DescendCompare));
        }
    }
}
