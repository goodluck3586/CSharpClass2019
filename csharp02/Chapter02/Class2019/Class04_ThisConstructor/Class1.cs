using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.b = 2;
            Console.WriteLine($"Class1(int {b}) 호출");
        }

        public Class1(int b, int c)
        {
            this.a = 1;
            this.b = 2;
            this.c = 3;
            Console.WriteLine($"Class1(int {b}, int {c}) 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
