using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 참조에 의한 매개변수 전달: ref, out */
namespace Method02
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref를 이용한 매개변수 전달
            int x = 33, y = 44;
            Console.WriteLine($"x={x}, y={y}");  // 33, 44
            Swap(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}");  // 44, 33

            // out을 이용한 매개변수 전달
            Divide(x, y, out int quotient, out int remainder);
            Console.WriteLine($"x: {x}, y: {y}, x/y: {quotient}, x%y: {remainder}");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Divide(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
    }
}
