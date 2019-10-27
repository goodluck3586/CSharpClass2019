using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 반환값이 있는 비동기 처리 Task<TResult>*/
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 비동기 함수 생성과 시작
            var myTask = Task<List<int>>.Run(()=>
            {
                Thread.Sleep(1000);

                List<int> list = new List<int>();
                list.Add(3);
                list.Add(4);
                list.Add(5);

                return list;
            });

            Console.WriteLine("메인 스레드 코드1");
            myTask.Wait();  // 비동기 코드 실행을 기다림.

            foreach (var item in myTask.Result)  // myTask.Result 비동기 코드 결과를 저장하고 있음.
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
