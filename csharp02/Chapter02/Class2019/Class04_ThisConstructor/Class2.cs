using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_ThisConstructor
{
    class Class2
    {
        int a, b, c;

        public Class2()
        {
            this.a = 1;
            Console.WriteLine("Class2() 호출");
        }

        public Class2(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"Class2(int {b}) 호출");
        }

        public Class2(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"Class2(int {b}, int {c}) 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
