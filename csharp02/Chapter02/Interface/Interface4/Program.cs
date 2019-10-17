using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 인터페이스를 상속하는 인터페이스 */
namespace Interface4
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    interface IFomattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger : IFomattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string msg = string.Format(format, args);
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), msg);
        }

        public void WriteLog(string msg)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFomattableLogger logger = new ConsoleLogger();
            logger.WriteLog("{0} + {1} = {2}", 1, 2, 3);
            logger.WriteLog("Hello World");
        }
    }
}
