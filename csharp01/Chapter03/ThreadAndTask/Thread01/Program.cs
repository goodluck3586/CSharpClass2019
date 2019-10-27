using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*  Thread(명령어를 실행하기 위핸 스케줄링 단위로 프로세스 내부에서 생성 가능) */
namespace Thread01
{
    class Program
    {
        // 메인 스레드
        static void Main(string[] args)
        {
            // 스레드의 존재 확인
            Thread thread = Thread.CurrentThread;  // 현재 실행중인 스레드
            Console.WriteLine(thread.ThreadState);

            // Thread.Sleep() : Running 상태인 스레드를 지정된 시간만큼 중지
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);  // 1초 중단
            }

            /* 새로운 스레드 생성 */
            Thread t = new Thread(ThreadFunc);
            //t.IsBackground = true;  // 메인이 끝나면 종료됨.
            t.Start();
            t.Join();  // t 스레드가 완료될 때까지 다른 스레드들은 대기

            Console.WriteLine("Main 스레드 종료");
        }

        private static void ThreadFunc()
        {
            Thread.Sleep(1000);
            Console.WriteLine("ThreadFunc() 실행");
            Console.WriteLine("스레드 종료");
        }
    }
}
