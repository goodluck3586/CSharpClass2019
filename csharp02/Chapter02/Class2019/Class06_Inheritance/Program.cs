
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class06_Inheritance
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base()");
        }

        ~Base()
        {
            Console.WriteLine("~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived()");
        }

        ~Derived()
        {
            Console.WriteLine("~Derived()");
        }
        public void DerivedMethod()
        {
            base.BaseMethod();
            Console.WriteLine("DerivedMethod()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.DerivedMethod();
        }
    }
}
