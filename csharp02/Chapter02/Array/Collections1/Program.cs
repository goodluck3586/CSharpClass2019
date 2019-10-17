using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Collections (크기가 정해져있지 않다.) */
/* ArrayList, List<> */
namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region System.Collections.ArrayList
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            for (int i = 6; i <= 10; i++)
                list.Add(i);

            Console.WriteLine("초기 상태");
            PrintArrayList(list);

            // 인덱스로 제거
            list.RemoveAt(2);
            PrintArrayList(list);

            // 인덱스로 새로운 값 추가
            list.Insert(2, 3);
            PrintArrayList(list);

            // 다양한 타입 수용 가능
            list.Add(3.14);
            list.Add("ArrayList");
            PrintArrayList(list);
            #endregion

            #region System.Collections.Generic.List<>
            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };
            for (int i = 6; i <= 10; i++)
                list2.Add(i);

            Console.WriteLine("초기 상태");
            PrintList(list2);

            list2.RemoveAt(2);
            PrintList(list2);

            list2.Insert(2, 3);
            PrintList(list2);
            #endregion
        }

        private static void PrintList(List<int> list2)
        {
            foreach (var item in list2)
                Console.Write($"{item} ");
             Console.WriteLine();
        }

        private static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
