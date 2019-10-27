using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 615p 예제 Abort, Interrupt를 이용한 스레드 중지 */
namespace Thread04_Abort
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
            }catch(ThreadAbortException e)
            {
                Console.WriteLine($"ThreadAbortException : {e.Message}");
            }catch(ThreadInterruptedException e)
            {
                Console.WriteLine($"ThreadInterruptedException : {e.Message}");
            }
            finally
            {
                Console.WriteLine("Clearing resource");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t = new Thread(task.KeepAlive);

            Console.WriteLine("Starting thread...");
            t.Start();
            Thread.Sleep(100);

            Console.WriteLine("스레드 중지 메소드 실행");
            //t.Abort();  // 스레드 취소 메소드 실행(즉시 종료)
            t.Interrupt();  // 스레드가 Running이 아닌 WaitJoinSleep 상태일 때 예외를 던짐.

            Console.WriteLine("메인 스레드 종료");
        }
    }
}
