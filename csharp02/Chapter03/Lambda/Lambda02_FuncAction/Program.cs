using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Action과 Func라는 델리게이트가 기본 제공 */
/* public delegate void Action<T1, T2>(T1 arg1, T2 arg2); */
/* public delegate TResult Func<in T1,in T2,out TResult>(T1 arg1, T2 arg2); */
namespace Lambda02_FuncAction
{
    class Program
    {
        delegate void AddDelegate<T1, T2>(T1 a, T2 b);
        delegate TResult SubtractDelegate<T1, T2, TResult>(T1 a, T2 b);
        static void Main(string[] args)
        {
            /* 사용자 정의 delegate 사용 */
            AddDelegate<int, int> addFunc = (a, b) => Console.WriteLine(a+b);
            addFunc(3, 4);

            SubtractDelegate<double, double, double> subFunc = (a, b) => a - b;
            Console.WriteLine(subFunc(9, 2)); 

            /* Action 델리게이트 사용 */
            Action<int, int> addAction = (a, b) => Console.WriteLine(a+b);
            addAction(4, 5);

            /* Func 델리게이트 사용 */

            Func<double, double, double> subFunc2 = (a, b) => a - b;
            Console.WriteLine(subFunc2(9, 8)); 
        }
    }
}
