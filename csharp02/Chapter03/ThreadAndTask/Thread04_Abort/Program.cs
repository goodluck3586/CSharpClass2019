using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 615p 예제 */
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
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine($"에러 처리: {e.Message}");
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine($"에러 처리: {e.Message}");
            }
            finally
            {
                Console.WriteLine("finally 코드");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SideTask st = new SideTask(100);
            Thread t = new Thread(st.KeepAlive);

            Console.WriteLine("스레드 시작");
            t.Start();
            Thread.Sleep(100);  // 0.1 초 멈춤

            Console.WriteLine("스레드 중지 명령 실행");
            //t.Abort();
            t.Interrupt();  // 스레드가 Running 상태이면 기다리다가, WaitJoinSleep 상태일 때 죽임.

            Console.WriteLine("메인 스레드 종료");
        }
    }
}
