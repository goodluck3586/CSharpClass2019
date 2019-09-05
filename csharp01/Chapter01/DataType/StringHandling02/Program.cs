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
            // char 배열로 문자열 생성
            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);
            Console.WriteLine(alphabet);

            // 문자열 서식 지정
            string result = string.Format("{0}DEF", "ABC");
            Console.WriteLine(result);
            result = string.Format("{0, -10}DEF", "ABC");
            Console.WriteLine(result);
            result = string.Format("{0, 10}DEF", "ABC");
            Console.WriteLine(result);

            // 날짜 서식
            DateTime dt = new DateTime(2019, 9, 2, 12, 3, 22);
            Console.WriteLine("{0}", dt);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Hour);
        }
    }
}
