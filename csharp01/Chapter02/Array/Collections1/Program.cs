using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ArrayList, List<> */
namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            // 초기화
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

            // item 추가
            for (int i = 6; i <= 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("초기상태");
            PrintArrayList(list);

            Console.WriteLine("list.RemoveAt(2)");  // 인덱스로 제거
            list.RemoveAt(2);
            PrintArrayList(list);

            Console.WriteLine("list.Insert(2, 3)");  // 인덱스로 추가
            list.Insert(2, 3);
            PrintArrayList(list);

            Console.WriteLine("다양한 데이터 타입 수용");
            list.Add("hello");
            list.Add("world");
            PrintArrayList(list);
            #endregion

            #region List<>
            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };
            for (int i = 6; i <= 10 ; i++)
            {
                list2.Add(i);
            }

            Console.WriteLine("초기 상태");
            PrintList(list2);

            Console.WriteLine("list2.RemoveAt(2)");
            list2.RemoveAt(2);
            PrintList(list2);

            Console.WriteLine("list2.Insert(2, 3)");
            list2.Insert(2, 3);
            PrintList(list2);
            #endregion

        }

        private static void PrintList(List<int> list2)
        {
            foreach (var item in list2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine('\n');
        }

        private static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine('\n');
        }
    }
}
