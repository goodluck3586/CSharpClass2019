using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 값 형식의 데이터 타입
 */
namespace DataType01
{
    class Program
    {
        static void Main(string[] args)
        {
            /****** 값 형식 초기화 ******/
            int i1, i2;
            System.Int32 i3;
            i1 = 0;
            i2 = new int();
            i3 = new System.Int32();

            Console.WriteLine("{0}, {1}, {2}", i1, i2, i3);


            /****** bool ******/
            bool b1, b2;
            b1 = true;
            b2 = new bool();

            Console.WriteLine($"{b1}, {b2}");
            Console.WriteLine(b1.GetType());

            /****** 정수 숫자 형식 ******/
            int num1 = 100;
            System.Int32 num2 = 200;

            Console.WriteLine("{0} ~ {1}", int.MinValue, int.MaxValue);

            // 숫자 형식 문자열 표현
            Console.WriteLine("{0,10}", 1234);  // 폭 10, 오른쪽 정렬
            Console.WriteLine("{0,-10}", 1234);  // 폭 10, 왼쪽 정렬
            Console.WriteLine("{0:c}", 1234);  // 통화표시
            Console.WriteLine("{0:d6}", 1234);  // 정수를 6자리로 표시
            Console.WriteLine("{0,10:d6}", 1234);

            /****** 부동 소수점 숫자 형식 ******/
            float f1 = 3.141592653589793238462643383279502884197169f;
            double d1 = 3.141592653589793238462643383279502884197169;
            decimal de1 = 3.141592653589793238462643383279502884197169m;

            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine(de1);

            // 숫자 형식 문자열 표현
            Console.WriteLine("{0:f2}", f1);
            Console.WriteLine("{0:f3}", f1);

            Console.WriteLine(f1.GetType());
            Console.WriteLine(d1.GetType());

            /****** char(유니코드 16비트 문자) ******/
            char ch1 = 'A';
            char ch2 = (char)97;  // char은 int 등의 숫자 형태로 암시적 형변환
            int number = ch1;

            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);
            Console.WriteLine(ch2);

            // System.char 메서드
            Console.WriteLine(ch1.Equals('A'));  // True
            Console.WriteLine(Char.IsLower(ch1));  // False

        }
    }
}
