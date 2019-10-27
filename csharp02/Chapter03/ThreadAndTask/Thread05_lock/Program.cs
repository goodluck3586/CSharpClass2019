using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// 여러 스레드가 하나의 자원에 접근하는 경우 공유자원 문제가 발생할 수 있다.
// 이 때 lock() 으로 해결
namespace Thread05_lock
{
    class NumClass
    {
        public int Number { get; set; }

        // Number 프로퍼티를 증가시키는 메소드
        public void IncreaseNum1(object obj)
        {
            NumClass nc = obj as NumClass;  // unboxing
            for (int i = 0; i < 10000; i++)
            {
                nc.Number++;
            }
        }

        // Number 프로퍼티를 증가시키는 메소드
        public void IncreaseNum2(object obj)
        {
            NumClass nc = obj as NumClass;  // unboxing
            for (int i = 0; i < 10000; i++)
            {
                lock (nc)  // nc 객체에 한 번에 하나의 스레드만 접근하도록 만듬.
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

                Console.WriteLine($"unsynchronizeMerhod() 실행 결과: {numObj1.Number}");
            }

            void synchronizeMethod()
            {
                Thread t1 = new Thread(numObj2.IncreaseNum2);
                Thread t2 = new Thread(numObj2.IncreaseNum2);
                t1.Start(numObj2);
                t2.Start(numObj2);

                t1.Join();
                t2.Join();

                Console.WriteLine($"unsynchronizeMerhod() 실행 결과: {numObj2.Number}");
            }
        }
    }
}
