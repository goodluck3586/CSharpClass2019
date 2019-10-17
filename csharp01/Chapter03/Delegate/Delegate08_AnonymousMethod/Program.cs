
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 익명 메소드: 다시 쓸 일이 없는 경우 유용 */
namespace Delegate08_AnonymousMethod
{
    // 두 숫자로 산술연산하는 일회용 메소드를 넘겨야 한다는 가정
    delegate int Calculate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(calc(3,4));
        }
    }
}
