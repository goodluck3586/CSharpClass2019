using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 432p 예제 */
namespace Delegate03_BubbleSort
{
    delegate int Compare(int a, int b);  // 델리게이트 선언
    class Program
    {
        // 오름차순 메소드: a>b → 1, a==b → 0, a<b → -1
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        // 내림차순 메소드
        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        // 버블 소트 메소드
        static void BubbleSort(int[] DataSet, Compare compare)
        {
            int temp;
            for (int i = 0; i < DataSet.Length - 1; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if(compare(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
                PrintArray(DataSet);
            }
        }

        private static void PrintArray(int[] dataSet)
        {
            foreach (var item in dataSet)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 12, 10, 18, 6, 11 };

            Console.WriteLine("오름차순 정렬");
            Console.Write("초기 상태: ");
            PrintArray(array);
            //Compare c1 = new Compare(AscendCompare);
            BubbleSort(array, new Compare(AscendCompare));

            Console.WriteLine("내림차순 정렬");
            Console.Write("초기 상태: ");
            PrintArray(array);
            //Compare c1 = new Compare(AscendCompare);
            BubbleSort(array, new Compare(DescendCompare));
        }
    }
}
