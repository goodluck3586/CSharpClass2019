using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate05_Chain
{
    delegate void CalcDelegateType(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            void Add(int a, int b)
            {
                Console.WriteLine($"{a} + {b} = {a+b}");
            }
            void Subtract(int a, int b)
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
            void Multiply(int a, int b)
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }
            void Divide(int a, int b)
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }

            CalcDelegateType calcFunc;
            calcFunc = Add;
            calcFunc(3, 4);

            calcFunc += Subtract;
            calcFunc(3, 4);

            calcFunc += Multiply;
            calcFunc += Divide;
            calcFunc(3, 4);

            calcFunc -= Add;
            calcFunc -= Subtract;
            calcFunc(3, 4);
        }
    }
}
