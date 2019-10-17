using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 무명형식: 선언과 동시에 인스턴스 생성, 읽기 전용
            var a = new { Name = "아이유", Age = 27 };
            Console.WriteLine($"{a.Name}, {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"{b.Subject} ");
            foreach(var score in b.Scores)
                Console.Write($"{score} ");
        }
    }
}
