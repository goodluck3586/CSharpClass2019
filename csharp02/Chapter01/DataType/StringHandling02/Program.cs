using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lettes = { 'a', 'b', 'c' };
            string alphabet = new string(lettes);
            Console.WriteLine(alphabet);

            string s1 = "Hello";
            string s2 = s1;
            s1 += " World";

            Console.WriteLine(s2);

            // Format() 메소드
            string result = string.Format("{0}DEF", "ABC");  // ABCDEF
            result = string.Format("{0, -10}DEF", "ABC");
            Console.WriteLine(result);

            // 날짜 서식
            DateTime dt = new DateTime(2019, 9, 3, 9, 21, 30);
            Console.WriteLine(dt);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("{0:d}", DateTime.Now);
            Console.WriteLine("{0:D}", DateTime.Now);
            Console.WriteLine("{0:f}", DateTime.Now);
            Console.WriteLine("{0:F}", DateTime.Now);
        }
    }
}
