using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// 스레드 여러개가 하나의 자원에 접근하는 경우 동기화 문제가 발생할 수 있다.
// lock 메소드를 사용하여 자원을 한 순간에 하나의 스레드만 접근하도록 강제
namespace Thread05_lock
{
    class NumClass
    {
        public int Number { get; set; }

        // 공유자원에 대한 스레드 동기화 처리가 되지 않은 메소드
        public void IncreaseNum1(object obj)
        {
            NumClass nc = obj as NumClass;
            for (int i = 0; i < 100000; i++)
            {
                nc.Number++;
            }
        }

        // lock을 사용해서 공유 자원에 하나의 스레드만 접근하도록 한 메소드
        public void IncreaseNum2(object obj)
        {
            NumClass nc = obj as NumClass;
            for (int i = 0; i < 100000; i++)
            {
                lock (nc)  // 한 순간에 오직 하나의 스레드만 접근 허용
                {
                    nc.Number++;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumClass numObj1 = new NumClass();
            NumClass numObj2 = new NumClass();

            unsynchronizeMethod();
            synchronizeMethod();

            void unsynchronizeMethod()
            {
                Thread t1 = new Thread(numObj1.IncreaseNum1);
                Thread t2 = new Thread(numObj1.IncreaseNum1);
                t1.Start(numObj1);
                t2.Start(numObj1);

                t1.Join();
                t2.Join();
                Console.WriteLine($"unsynchronizeMethod() 결과 : {numObj1.Number}");
            }

            void synchronizeMethod()
            {
                Thread t1 = new Thread(numObj2.IncreaseNum2);
                Thread t2 = new Thread(numObj2.IncreaseNum2);
                t1.Start(numObj2);
                t2.Start(numObj2);

                t1.Join();
                t2.Join();
                Console.WriteLine($"synchronizeMethod() 결과 : {numObj2.Number}");
            }
        }
    }
}
