using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate06_Chain
{
    class Program
    {
        // 1. 델리게이트 선언
        delegate void ThereIsAFire(string location);

        static void Main(string[] args)
        {
            // 2. 델리게이트 인스턴스 생성, 모든 메소드를 체인으로 연결
            ThereIsAFire Fire = new ThereIsAFire(Call119);
            Fire += ShotOut;
            Fire += Escape;

            // 3. 델리게이트 실행
            Fire("송정동");
        }

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? {location}에 불이났어요. ");
        }
        static void ShotOut(string location)
        {
            Console.WriteLine($"피하세요!!! {location}에 불이났어요. ");
        }
        static void Escape(string location)
        {
            Console.WriteLine($"어서 {location}에서 나갑시다. ");
        }
    }
}
