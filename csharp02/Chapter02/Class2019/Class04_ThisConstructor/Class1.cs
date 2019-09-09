using System;

namespace Class04_ThisConstructor
{
    class Class1
    {
        int a, b, c;

        public Class1()
        {
            this.a = 1;
            Console.WriteLine("Class1() 호출");
        }

        public Class1(int b)
        {
            this.a = 1;
            this.b = b;
            Console.WriteLine($"Class1(int {b}) 호출");
        }

        public Class1(int b, int c)
        {
            this.a = 1;
            this.b = b;
            this.c = c;
            Console.WriteLine($"Class1(int {b}, int {c}) 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
