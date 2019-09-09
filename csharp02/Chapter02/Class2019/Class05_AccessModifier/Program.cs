using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_AccessModifier
{
    class A
    {
        public int value1 = 10;
        private int value2 = 20;
        protected int value3 = 30;

        class C : A
        {
            public int GetValue2()
            {
                return value2;
            }
        }
        public void SetValue2(int v)
        {
            value2 = v;
        }

    }

    class B : A
    {
        public int GetValue3()
        {
            return value3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.value1); 
        }
    }
}
