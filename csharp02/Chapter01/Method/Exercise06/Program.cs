using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 알파벳 사이의 알파벳을 모두 반환하는 메소드 작성
 * FullSequenceOfLetters("ds") → "defghijklmnopqrs" 
 * FullSequenceOfLetters("or") → "opqr"
 */
namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FullSequenceOfLetters("ds"));
            Console.WriteLine(FullSequenceOfLetters2("ds"));
        }

        static string FullSequenceOfLetters(string s)
        {
            char a = s[0];
            char b = s[1];
            Console.WriteLine($"{a}, {a.GetType()}");

            char[] charArr = new char[b-a+1];

            for (int i = 0; i < b-a+1; i++)
            {
                charArr[i] = (char)(a + i);
            }

            string returnStr = new string(charArr);
            return returnStr;
        }

        static string FullSequenceOfLetters2(string s)
        {
            char a = s[0];
            char b = s[1];
            Console.WriteLine($"{a}, {a.GetType()}");

            string returnStr = null;

            for (int i = 0; i < b - a + 1; i++)
            {
                returnStr += (char)(a + i);
            }
            return returnStr;
        }
    }
}
