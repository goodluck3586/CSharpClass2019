using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 이름없는 형식(Anonymous Type) */
namespace Properties4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 선언과 동시에 인스턴스 할당, 읽기 전용
            var a = new { Name = "아이유", Age = 26 };
            Console.WriteLine($"{a.Name}, {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject: {b.Subject}, Scores: ");
            foreach(int score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}
