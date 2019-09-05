using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ref, out을 이용한 메서드 구현 */
namespace Method03
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref를 이용한 참조에 의한 매개변수 전달
            int x = 3, y = 4;
            Console.WriteLine($"x: {x}, y: {y}");
            // Swap() 메서드를 만들어  ref로 x와 y의 값이 바뀌도록 하시오.
            Swap(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");

            // out을 이용한 몫과 나머지 구하기
            int a = 20, b = 3;
            // Divide() 함수 구현: quotient, remainder 변수 생성
            Divide(a, b, out int qutient, out int remainder);
            Console.WriteLine($"a: {a}, b: {b}, a/b: {qutient}, a%b: {remainder}");
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        private static void Divide(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
    }
}
