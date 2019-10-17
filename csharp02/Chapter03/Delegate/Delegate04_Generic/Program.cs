using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 일반화 대리자 : 일반화(Generic) 메소드 참조 */
namespace Delegate04_Generic
{
    delegate int Compare<T>(T a, T b);  // 델리게이트 선언
    class Program
    {
        // 오름차순 메소드: a>b → 1, a==b → 0, a<b → -1
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);  // a>b → 1, a==b → 0, a<b → -1
        }

        // 내림차순 메소드
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);  // a>b → 1, a==b → 0, a<b → -1
        }

        // 버블 소트 메소드
        static void BubbleSort<T>(T[] DataSet, Compare<T> compare)
        {
            T temp;
            for (int i = 0; i < DataSet.Length - 1; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
                PrintArray(DataSet);
            }
        }

        private static void PrintArray<T>(T[] dataSet)
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
            BubbleSort(array, new Compare<int>(AscendCompare));

            double[] array2 = { 1.2, 1.0, 1.8, 0.6, 1.1 };
            Console.WriteLine("내림차순 정렬");
            Console.Write("초기 상태: ");
            PrintArray(array2);
            //Compare c1 = new Compare(AscendCompare);
            BubbleSort(array2, new Compare<double>(DescendCompare));
        }
    }
}
