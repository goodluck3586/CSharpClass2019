using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface ILogger  // 인터페이스 이름은 보통 대문자 I로 시작
    {
        void WriteLog(string log);
    }

    // 인터페이스를 상속받은 클래스는 인터페이스의 멤버들을 구현해야 한다.
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine(log);
        }

        public void DerivedMethod()
        {
            Console.WriteLine("DerivedMethod()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger c1 = new ConsoleLogger();
            c1.WriteLog("Hello World!!!");
            c1.DerivedMethod();

            // 인터페이스는 인스턴스는 만들지 못하지만, 부모 참조변수에 자식을 담을 수 있다.
            ILogger c2 = new ConsoleLogger();
            c2.WriteLog("Hi C#");
            if(c2 is ConsoleLogger)
            {
                ConsoleLogger cl = c2 as ConsoleLogger;
                ConsoleLogger cl2 = (ConsoleLogger)c2;
                cl.DerivedMethod();
                cl2.DerivedMethod();
            }
            
        }
    }
}
