using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network03_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클라이언트");

            TcpClient tcpClient = new TcpClient("127.0.0.1", 3000);

            using(NetworkStream ns = tcpClient.GetStream())
            {
                using(StreamReader sr = new StreamReader(ns))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            Console.WriteLine("클라이언트 종료");
            tcpClient.Close();
        }
    }
}
