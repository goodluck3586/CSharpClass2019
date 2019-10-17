using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 익명메소드: 다시 사용하지 않는 경우 유용하다. */
namespace Delegate07_AnonymousMethod
{
    delegate int CalcDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            CalcDelegate calc = delegate (int a, int b)
            {
                return a + b;
            };
            Calculate(3, 4, calc);

            Calculate(3, 4, (int a, int b)=>a - b);
        }

        static void Calculate(int a, int b, CalcDelegate calcFunc)
        {
            Console.WriteLine(calcFunc(a, b)); 
        }
    }
}
