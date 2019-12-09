using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network02_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("서버");

            TcpListener tcpListener = new TcpListener(IPAddress.Parse("10.120.73.155"), 3000);
            tcpListener.Start();    // 클라이언트 요청 수신 대기 시작

            // 클라이언트 접속 무한 대기 → 클라이언트가 접속 → 해당 클라이언트와 연결된 TcpClient 인스턴스 반환
            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            Console.WriteLine($"클라이언트 연결 성공: {tcpClient.Client.RemoteEndPoint}");

            using (NetworkStream ns = tcpClient.GetStream())    // 데이터 송수신 스트림
            {
                using(StreamWriter sw = new StreamWriter(ns))
                {
                    sw.AutoFlush = true;    // 네트워크 스트림 버퍼가 차지않았어도 전송해라.

                    string sendData = "";
                    while ((sendData = Console.ReadLine())!="exit")
                    {
                        sw.WriteLine(sendData); // '\n\r' 추가
                    }
                }
            }
            Console.WriteLine("서버 종료");
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}
