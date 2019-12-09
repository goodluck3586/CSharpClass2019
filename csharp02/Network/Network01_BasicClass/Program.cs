using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/* 네트워크 정보 클래스: IPAddress, Dns, IPHostEntry, IPEndPoint */
namespace Network01_BasicClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. IPAddress 클래스 : ip주소 ↔ long형 값 변환
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            Console.WriteLine($"ipAddress.Address : {ipAddress.Address}");  // long형 값
            Console.WriteLine($"ipAddress.ToString() : {ipAddress.ToString()}");
            Console.WriteLine();

            // 2. Dns 클래스
            Console.WriteLine($"Dns.GetHostName() : {Dns.GetHostName()}");  // 로컬 컴퓨터 이름
            IPAddress[] naverIps = Dns.GetHostAddresses("www.naver.com");
            foreach (var ip in naverIps)
            {
                Console.WriteLine(ip);
            }
            Console.WriteLine();

            IPAddress[] myIps = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var ip in myIps)
            {
                Console.WriteLine(ip);      // 0번(IPv6), 1번(IPv4)
            }
            Console.WriteLine();

            // 3. IPHostEntry 클래스: 호스트 주소 정보에 대한 컨테이너 클래스
            IPHostEntry naverIPHost = Dns.GetHostEntry("www.naver.com");
            foreach (var ip in naverIPHost.AddressList)
            {
                Console.WriteLine($"naverIPHost.AddressList : {ip}");
            }
            Console.WriteLine($"naverIPHost.HostName : {naverIPHost.HostName}");
            Console.WriteLine();

            // 4. IPEndPoint : 목지지 ip 주소와 포트번호 저장
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);
            Console.WriteLine($"iPEndPoint.Address : {iPEndPoint.Address}");
            Console.WriteLine($"iPEndPoint.Port : {iPEndPoint.Port}");
            Console.WriteLine($"iPEndPoint.ToString() : {iPEndPoint.ToString()}");  // 127.0.0.1:3000
            Console.WriteLine();
        }
    }
}
