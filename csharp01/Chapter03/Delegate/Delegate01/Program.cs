using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate01
{
    /* delegate(메소드를 가리킬 수 있는 타입) */
    class Program
    {
        // delegate : 메소드에 대한 참조
        // 1. 델리게이트 선언
        delegate int MyDelegateType(int a, int b);  // delegate는 Type이다.

        static void Main(string[] args)
        {
            int Plus(int a, int b)
            {
                return a + b;
            }

            int Subtract(int a, int b)
            {
                return a - b;
            }

            // 2. 델리게이트 참조 변수 생성
            MyDelegateType myDelegate;

            // 3. 델리게이트 인스턴스 생성
            myDelegate = new MyDelegateType(Plus);

            // 4.  델리게이트 호출
            Console.WriteLine(myDelegate(3, 4));

            myDelegate = Subtract;
            Console.WriteLine(myDelegate(3, 4));

            Calcuator calc = new Calcuator();
            MyDelegateType calcDelegate;  // 델리게이트 참조 변수

            calcDelegate = new MyDelegateType(calc.Plus);
            Console.WriteLine(calcDelegate(5, 6));  

            calcDelegate = Calcuator.Subtract;
            Console.WriteLine(calcDelegate(10, 5));

            calcDelegate = calc.Plus;
            calcDelegate += Calcuator.Subtract;
            Console.WriteLine(calcDelegate(7,8));
        }
    }

    class Calcuator
    {
        public int Plus(int a, int b)
        {
            Console.WriteLine("public int Plus(int a, int b)");
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            Console.WriteLine("public int Subtract(int a, int b)");
            return a - b;
        }
    }
}
