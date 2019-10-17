using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Action과 Func 델리게이트를 활용하기 */

namespace Lambda02_FuncAction
{
    delegate void AddDelegate<T1, T2>(T1 a, T2 b);  // 사용자정의 델리게이트
    delegate TResult SubtractDelegate<T1, T2, TResult>(T1 a, T2 b);   // 사용자정의 델리게이트

    class Program
    {
        static void Main(string[] args)
        {
            // 기존 방식: 사용자 델리게이트 선언 후 참조변수 생성
            AddDelegate<int, int> addDel = (a, b) => Console.WriteLine(a+b);
            addDel(3, 4);

            SubtractDelegate<int, int, string> subDel = (a, b) => (a-b).ToString();
            Console.WriteLine(subDel(3, 4));

            // Action 델리게이트 활용: 반환값이 없는 경우
            Action<int, int> actionDel = (a, b) => Console.WriteLine(a + b);
            actionDel(3, 4);

            // Func 델리게이트 활용: 반환값이 있는 경우
            Func<double, double, double> func = (a, b) => a * b;
            Console.WriteLine(func(3.14, 3495678423));
        }
    }
}
