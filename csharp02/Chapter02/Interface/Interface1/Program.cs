using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface ILogger
    {
        void WriteLog(string log);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {log}");
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
            ConsoleLogger cl = new ConsoleLogger();
            cl.WriteLog("Hello World!!!");
            cl.DerivedMethod();

            ILogger cl2 = new ConsoleLogger();
            cl2.WriteLog("Hi C#");
            if(cl2 is ConsoleLogger)
            {
                ConsoleLogger cc = cl2 as ConsoleLogger;
                cc.DerivedMethod();
            }
        }
    }
}
