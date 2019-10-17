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
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger();
            logger.WriteLog("Hello World");
            logger.WriteLog("{0} + {1} = {2}", 1, 2, 3);
        }
    }
}
