using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* System.Threading.Tasks : 병렬 코드, 비동기 코드 작성하는 기능들 */
/* System.Threading.Tasks.Task 클래스 : 비동기 코드 작성하는데 사용 */
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메인 스레드 시작");

            Action someAction = () =>
            {
                Console.WriteLine("비동기 메소드1 시작");
                Thread.Sleep(1000);
                Console.WriteLine("비동기 메소드1 종료");
            };

            // 1. 비동기 실행방법: Task 객체 생성 + Task.start() 실행
            Task myTask1 = new Task(someAction);
            myTask1.Start();  // 비동기 코드 실행

            // 2. 비동기 실행방법: Task.Run()으로 한 번에 실행
            var myTask2 = Task.Run(() =>
            {
                Console.WriteLine("비동기 메소드2 시작");
                Thread.Sleep(1000);
                Console.WriteLine("비동기 메소드2 종료");
            });

            Console.WriteLine("메인 스레드 코드1");

            myTask1.Wait();  // 비동기 실행이 완료될 때 까지 기다리겠다.
            myTask2.Wait();

            Console.WriteLine("메인 스레드 종료");
        }
    }
}
