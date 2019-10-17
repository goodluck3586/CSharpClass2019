using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 배열을 초기화하는 방법 */
namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 방법1: 코드를 읽기 좋음.
            string[] array1 = new string[3] { "안녕", "Hello", "World" };
            foreach(string s in array1)
                Console.Write($"{s} ");
            Console.WriteLine('\n');

            // 방법2
            string[] array2 = new string[] { "안녕", "Hello", "World" };
            foreach (string s in array2)
                Console.Write($"{s} ");
            Console.WriteLine('\n');

            // 방법3: 코드가 짦음.
            string[] array3 = { "안녕", "Hello", "World" };
            foreach (string s in array3)
                Console.Write($"{s} ");
            Console.WriteLine('\n');

            Console.WriteLine(array1.GetType());
            Console.WriteLine(array1.GetType().BaseType);
        }
    }
}
