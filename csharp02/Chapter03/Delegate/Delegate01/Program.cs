using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

/* delegate(메소드에 대한 참조) */
namespace Delegate01
{
    // 1. 델리게이트 선언
    delegate int MyDelegateType(int a, int b);  // MyDelegateType는 Type이다. (int, float 같은...)

    class Program
    {
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

            // 2. 델리게이트 참조변수 생성
            MyDelegateType myDelegate;
            // 3. 델리게이트의 인스턴스 생성, 이때 참조할 메소드를 설정한다.
            myDelegate = new MyDelegateType(Plus);
            // 4. 델리게이트 실행
            Console.WriteLine(myDelegate(3, 4));  // 7

            myDelegate = Subtract;
            Console.WriteLine(myDelegate(3, 4));

            Calcultor calc = new Calcultor();
            MyDelegateType calcDelegate;

            calcDelegate = new MyDelegateType(calc.Plus);
            Console.WriteLine(calcDelegate(5, 10));

            calcDelegate = new MyDelegateType(Calcultor.Subtract);
            Console.WriteLine(calcDelegate(5, 10));

            // 델리게이트는 인스턴스를 생성할 때 생성자 대신 메소드명을 이용할 수 있다.
            calcDelegate = calc.Plus;
            calcDelegate += Calcultor.Subtract;  // 메소드를 2개 이상 연결할 수 있다.
            calcDelegate(1, 2);
        }
    }

    class Calcultor
    {
        public int Plus(int a, int b)
        {
            Console.WriteLine("Plus(int a, int b)");
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract(int a, int b)");
            return a - b;
        }
    }
}
