using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* (input-parameters) => expression */
namespace Lambda01
{
    class Program
    {
        delegate int? CalcDelegate(int a, int b);
        // 1. 제네릭 타입의 사칙연산 처리용 델리게이트 선언
        delegate T Calculator2<T>(T a, T b);

        static void Main(string[] args)
        {
            #region 람다 연습
            // 델리게이트 키워드를 사용한 익명메소드
            CalcDelegate calc1 = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(calc1(3, 4));

            // 람다식으로 표현한 익명메소드
            CalcDelegate calc2 = (a, b) => a + b;
            Console.WriteLine(calc2(3, 4));

            calc2 = (a, b) =>
            {
                if (b == 0)
                    return null;
                return a / b;
            };
            Console.WriteLine(calc2(10, 3));
            if(calc2(10,0)==null)
                Console.WriteLine("0으로 못 나눔.");
            else
                Console.WriteLine(calc2(10, 0));
            #endregion
            // 2. 제네릭 타입의 델리게이트 참조변수 생성하면서 사칙연산 람다식 할당
            Calculator2<double> calc3 = (a, b) => a + b;
            // 3. 위 참조변수로 Calc 메소드 호출
            Calc<double>(3.14, 6.56, calc3);
            Calc<int>(100, 200, (a, b) => a + b);
        }

        // 사칙연산 처리 메소드
        static void Calc<T>(T a, T b, Calculator2<T> CalcFunc)
        {
            Console.WriteLine(CalcFunc(a, b));
        }
    }
}
