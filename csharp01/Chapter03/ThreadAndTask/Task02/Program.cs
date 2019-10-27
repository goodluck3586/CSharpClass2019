using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* Task<TResult> : 비동기 실행결과를 쉽게 얻을 수 있다. */
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTask = Task<List<int>>.Run(() =>
            {
                Thread.Sleep(1000);

                List<int> list = new List<int>();
                list.Add(3);
                list.Add(4);
                list.Add(5);

                return list;
            });
            Console.WriteLine("동기 문자열");
            myTask.Wait();

            foreach (var item in myTask.Result)  // List<int>
                Console.Write($"{item} ");
            Console.WriteLine();

            var myList = new List<int>();
            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.AddRange(myTask.Result);  // 비동기 처리 결과인 List<int>를 myList 뒤에 붙인다.

            foreach (var item in myList)  // List<int>
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
