using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling01
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            /****** 문자열 찾기 ******/
            // IndexOf() : 찾는 문자열 위치 반환
            Console.WriteLine(greeting.IndexOf("Good"));  // 0
            Console.WriteLine(greeting.IndexOf("o"));  // 1

            // LastIndexOf() : 찾는 문자열의 위치 반환(뒤에서)
            Console.WriteLine(greeting.LastIndexOf("Good"));  // 0
            Console.WriteLine(greeting.LastIndexOf("o"));  // 6

            // StartWith() : 지정된 문자열로 시작하는지 판단
            Console.WriteLine(greeting.StartsWith("Good"));  // true
            Console.WriteLine(greeting.StartsWith("o"));  // false

            // EndWith() : 지정된 문자열로 끝나는지 판단
            Console.WriteLine(greeting.EndsWith("Good"));  // false
            Console.WriteLine(greeting.EndsWith("Morning"));  // true

            // Contains() : 지정된 문자열을 포함하는지 판단
            Console.WriteLine(greeting.Contains("Good"));  // true
            Console.WriteLine(greeting.Contains("Evening"));  // false

            // Replace() : 지정된 문자열로 수정된 문자열 반환
            Console.WriteLine(greeting.Replace("Morning", "Evening"));

            /****** 문자열 변형 ******/
            // ToLower(), ToUpper()
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.ToUpper());

            // Insert(), Remove()
            Console.WriteLine("Happy Day!".Insert(6, "Sunny "));
            Console.WriteLine("I Don't love you!!!".Remove(2, 6));

            // Trim()
            string str = " No Space ";
            Console.WriteLine($"'{str}'");
            Console.WriteLine($"'{str.Trim()}'");

            /****** 문자열 쪼개기 ******/
            //Substring()
            string words = "안녕하세요 지금은 " +
                "\tC# 수업 중입니다. 오늘 dataType, 문자열을 배웠어요. ";
            Console.WriteLine(words);
            Console.WriteLine(words.Substring(0, 5));  // 안녕하세요
            Console.WriteLine(words.Substring(35));  // 문자열을 ~

            //Split() : 지정된 기준에 따라 문자열 분할 → 배열 반환
            string[] split1 = words.Split(new char[] { ' ', '\t', ',' });
            Console.WriteLine(split1.Length);
            foreach(string s in split1)
            {
                if(s.Trim() != "")
                    Console.WriteLine(s);
            }
        }
    }
}
