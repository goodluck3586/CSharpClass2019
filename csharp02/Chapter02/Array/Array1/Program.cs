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
            // 방법 1 : 코드를 읽는 가독성이 높음.
            string[] array1 = new string[3] { "안녕", "hello", "halo" };
            foreach(string s in array1)
                Console.WriteLine(s);

            // 방법 2
            string[] array2 = new string[] { "안녕", "hello", "halo" };
            foreach (string s in array2)
                Console.WriteLine(s);

            // 방법 3
            string[] array3 = { "안녕", "hello", "halo" };
            foreach (string s in array3)
                Console.WriteLine(s);

            // 배열의 타입
            Console.WriteLine(array1.GetType());
            Console.WriteLine(array1.GetType().BaseType);
        }
    }
}
