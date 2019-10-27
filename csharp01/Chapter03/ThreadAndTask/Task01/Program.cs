using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// System.Threading.Tasks : 병렬 코드나 비동기 코드 작성
// System.Threading.Tasks.Task : 비동기 코드 작성
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 비동기 메소드 실행방법1 : Task 객체 생성 + Start() 메소드 실행
            Action someAction = () =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("비동기 출력1");
            };

            Task myTask1 = new Task(someAction);  // Task 객체 생성
            myTask1.Start();  // Task 객체 실행(비동기로 실행됨.)

            // 비동기 메소드 실행방법2 : Task.Run() 메소드로 Task 생성과 실행을 한 번에 처리.
            var myTask2 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("비동기 출력2");
            });

            Console.WriteLine("동기 실행");

            myTask1.Wait();  // myTask1 비동기 실행이 완료될 때까지 기다림.
            myTask2.Wait();

            Console.WriteLine("프로그램 종료...");
        }
    }
}
