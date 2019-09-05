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
            Console.WriteLine(greeting + '\n');

            /***** 문자열 찾기 *****/
            // IndexOf() : 찾는 문자열의 위치 반환
            Console.WriteLine(greeting.IndexOf("Good"));  // 0
            Console.WriteLine(greeting.IndexOf("o"));  // 1

            // LastIndex() : 찾는 물자열의 위치 반환(뒤에서 부터)
            Console.WriteLine(greeting.LastIndexOf("Good"));  // 0 
            Console.WriteLine(greeting.LastIndexOf("o"));     // 6

            // StartWith() : 지정된 문자열로 시작하는지 판단하여 참/거짓 반환
            Console.WriteLine(greeting. StartsWith("Good"));  // true
            Console.WriteLine(greeting.StartsWith("o"));     // false

            // EndWith() : 지정된 문자열로 끝나는지 판단하여 참/거짓 반환
            Console.WriteLine(greeting.StartsWith("Good"));        // false
            Console.WriteLine(greeting.StartsWith("Morning"));     // true

            // Contains() : 지정된 문자열을 포함하는지 판단하여 참/거짓 반환
            Console.WriteLine(greeting.Contains("Good"));        // true
            Console.WriteLine(greeting.Contains("Evening"));     // false

            /***** 문자열 변형하기 *****/
            // Replace() : 지정된 문자열을 다른 문자열로 수정한 문자열 반환
            Console.WriteLine(greeting.Replace("Morning", "Evening"));

            // ToLower(), ToUpper()
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.ToUpper());

            // Insert(), Remove()
            Console.WriteLine("Happy Day!".Insert(5, " Sunny"));
            Console.WriteLine("I Don't love you".Remove(2, 6));

            // Trim
            string str = " No Space ";
            Console.WriteLine($"'{str.Trim()}'");
            Console.WriteLine($"'{str.TrimStart()}'");
            Console.WriteLine($"'{str.TrimEnd()}'");

            /***** 문자열 분할하기 *****/
            // Substring(): 문자열 추출
            string words = "안녕, \t 오늘은 9월 3일 화요일... 즐거운 C#, 앱프 시간이야.";
            Console.WriteLine(words);
            Console.WriteLine(words.Substring(30));
            Console.WriteLine(words.Substring(0, 2));  // 안녕
            Console.WriteLine('\n');

            // Split() : 문자열을 지정된 기준에 따라 분리된 배열 반환
            string[] split1 = words.Split(new char[] { ',' , ' ', '\t'});

            Console.WriteLine(split1.Length);
            foreach (string s in split1)
            {
                if(s.Trim() != "")
                    Console.WriteLine(s);
            }

            string[] split2 = words.Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(split2.Length);
            foreach (string s in split2)
            {
                if (s.Trim() != "")
                    Console.WriteLine(s);
            }
        }
    } 
}
