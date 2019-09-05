using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 널 조건부 연산자
 */
namespace Operator01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********** null 조건부 연산자 **********/
            ArrayList arr = null;
            arr?.Add("야구");
            arr?.Add("축구");
            Console.WriteLine(arr?.Count);
            Console.WriteLine(arr?[0]);

            arr = new ArrayList();
            arr?.Add("야구");
            arr?.Add("축구");
            Console.WriteLine(arr?.Count);
            Console.WriteLine(arr?[0]);

            /*********** null 병합 연산자 **********/
            int? a = null;
            Console.WriteLine($"{a ?? 0}");  // a가 null이면 ?? 뒤의 값이 출력

            a = 100;
            Console.WriteLine($"{a ?? 0}");
        }
    }
}
