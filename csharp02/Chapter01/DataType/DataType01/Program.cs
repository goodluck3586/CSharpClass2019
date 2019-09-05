using System;

/*
 * 값 형식 데이터 타입
 */

namespace DataType01
{
    class Program
    {
        static void Main(string[] args)
        {
            /********** C#은 강한 형식의 언어이다. **********/
            int a = 5;
            int b = a + 2;

            bool test = true;
            //int c = a + test;  // 타입 에러


            /********** 값 형식 초기화 **********/
            //int i1, i2;
            //Console.WriteLine(i1);  // 초기화 에러

            // 초기화
            int i1 = 0;
            System.Int32 i2 = new System.Int32();
            int i3 = new int();

            Console.WriteLine("{0}, {1}, {2}", i1, i2, i3);


            /********** bool **********/
            bool b1 = new bool();  // bool == System.Boolean
            System.Boolean b2 = new System.Boolean();

            Console.WriteLine(b1);
            Console.WriteLine(b1.GetType());


            /********** 정수 숫자 형식 **********/
            int num1 = 100;
            int num2 = 0x2A;  // 정수 리터럴은 10진수, 16진수(0x), 2진수(0b)로 지정할 수 있다.
            Console.WriteLine("num1={0}, num2={1}", num1, num2);

            // int의 범위
            Console.WriteLine("{0} ~ {1}", int.MinValue, System.Int32.MaxValue);

            // 표준 숫자 형식 문자열
            Console.WriteLine("{0,10}", 1234);  // 폭 10에 오른쪽 정렬
            Console.WriteLine("{0:C}", 1234);  // 통화형식으로 출력
            Console.WriteLine("{0:d6}", 1234);  // 001234
            Console.WriteLine("{0,10:d6}", 1234);


            /********** 부동소수점 숫자 형식 **********/
            float f1 = 3.141592653589793238462643383279502884197169f;
            double d1 = 3.141592653589793238462643383279502884197169;
            decimal de = 3.141592653589793238462643383279502884197169m;

            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine(de);


            /********** char(유니코드 16비트 문자) **********/
            char ch1 = 'A';
            char ch2 = (char)97;

            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);
            Console.WriteLine(ch2);

            // System.Char 메서드
            Console.WriteLine(ch1.Equals('A'));
            Console.WriteLine(Char.IsLower(ch1));  // 소문자 인가?
            Console.WriteLine(Char.IsUpper(ch1));  // 대문자 인가?
        }
    }
}
