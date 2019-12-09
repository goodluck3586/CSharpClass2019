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
            // 1. IPAddress 클래스: ip주소 ↔ long형 값 변환
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            Console.WriteLine($"iPAddress.Address : {iPAddress.Address}");
            Console.WriteLine($"iPAddress.ToString() : {iPAddress.ToString()}");
            Console.WriteLine();

            // 2. Dns 클래스
            Console.WriteLine($"Dns.GetHostName() : {Dns.GetHostName()}");  // LAPTOP-FN03UG3K
            IPAddress[] ipAdds = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var ip in ipAdds)
            {
                Console.WriteLine(ip);      // 0번은 IPv6, 1번은 IPv4
            }

            IPAddress[] ipAdds2 = Dns.GetHostAddresses("www.naver.com");
            foreach (var ip in ipAdds2)
            {
                Console.WriteLine(ip);      
            }
            Console.WriteLine();

            // 3. IPHostEntry : 인터넷 호스트 주소 정보에 대한 컨테이너 클래스
            IPHostEntry naverIPHostEntry = Dns.GetHostEntry("www.naver.com");
            foreach (var ip in naverIPHostEntry.AddressList)
            {
                Console.WriteLine(ip);
            }
            Console.WriteLine($"naverIPHostEntry.HostName : {naverIPHostEntry.HostName}");

            IPHostEntry myIPHostEntry = Dns.GetHostEntry(Dns.GetHostName());   // LAPTOP-FN03UG3K
            foreach (var ip in myIPHostEntry.AddressList)
            {
                Console.WriteLine(ip);
            }
            Console.WriteLine($"naverIPHostEntry.HostName : {myIPHostEntry.HostName}");

            // 4. IPEndPoint : 목적지 ip주소, 포트번호 저장
            IPAddress ipAdd = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEndPoint = new IPEndPoint(ipAdd, 3000);
            Console.WriteLine($"iPEndPoint.Address : {iPEndPoint.Address}");    // 127.0.0.1
            Console.WriteLine($"iPEndPoint.Port : {iPEndPoint.Port}");          //3000
            Console.WriteLine($"iPEndPoint.ToString() : {iPEndPoint.ToString()}");  // 127.0.0.1:3000
        }
    }
}
