using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* Thread(명령어를 실행하기 위한 스케줄링 단위) */
namespace Thread01
{
    class Program
    {
        // 메인 스레드는 기본 생성됨.
        static void Main(string[] args)
        {
            // 스레드의 존재 확인
            Thread thread = Thread.CurrentThread;  // 현재 실행중인 스레드에 접근하는 정적 속성
            Console.WriteLine(thread.ThreadState);  // Running

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);  // 스레드를 지정된 시간만큼 중지시킴.
            }

            // 새로운 스레드 생성
            Thread t = new Thread(threadFunc);  // 생성
            t.IsBackground = true;  // 메인이 종료되면 다른 스레드도 종료시킴.
            t.Start();  // 스레드 실행
            //t.Join();  // t 스레드가 종료될 때 까지 다른 스레드 대기

            Console.WriteLine("메인 스레드 종료");
        }

        private static void threadFunc()
        {
            Thread.Sleep(1000);
            Console.WriteLine("threadFunc() 실행");
            Console.WriteLine("threadFunc() 종료");
        }
    }
}
