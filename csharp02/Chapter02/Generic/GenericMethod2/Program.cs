using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 교재 376p 예제(CopyingArray) */
namespace GenericMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);
            PrintArray<int>(source);
            PrintArray<int>(target);

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];
            CopyArray<string>(source2, target2);
            PrintArray<string>(source2);
            PrintArray<string>(target2);
        }

        private static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine('\n');
        }

        private static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
