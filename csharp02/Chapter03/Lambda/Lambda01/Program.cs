using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* (input-parameters) => expression */
namespace Lambda01
{
    delegate int? Calculate(int a, int b);
    delegate T Claculate2<T>(T a, T b);

    class Program
    {
        static void Main(string[] args)
        {
            // delegate 키워드를 사용한 무명 메소드 구현
            Calculate calc1 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(calc1(3, 4));

            // 람다식을 사용한 무명 메소드 구현
            Calculate calc2 = (a, b) => a + b;
            Console.WriteLine(calc2(15, 10));

            calc2 += (a, b) =>
            {
                if (b == 0)
                    return null;
                return a / b;
            };
            Console.WriteLine(calc2(5, 10));

            // 제네릭 델리게이트 참조변수 생성, 람다식으로 덧셈 메소드 추가
            Claculate2<double> calc3 = (a, b) => a - b;
            // Clac<T>( ) 실행
            Calc<double>(3.14, 1.54, calc3);
            Calc<int>(1, 2, (a, b) => a + b);
        }

        static void Calc<T>(T a, T b, Claculate2<T> CalcFunc)
        {
            Console.WriteLine(CalcFunc(a, b));
        }
    }
}
