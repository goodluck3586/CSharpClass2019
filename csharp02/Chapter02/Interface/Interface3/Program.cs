using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    interface ILogger
    {
        void WriteLog(string log);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string log)
        {
            writer.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class ClimateMonotor
    {
        private ILogger logger;

        public ClimateMonotor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력하세요: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog("현재 온도: " + temperature);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 파일에 로그 출력
            ClimateMonotor fileMonitor = new ClimateMonotor(new FileLogger("MyLog.txt"));
            fileMonitor.start();

            // 콘솔에 로그 출력
            ClimateMonotor consoleMonitor = new ClimateMonotor(new  ConsoleLogger());
            consoleMonitor.start();
        }
    }
}
