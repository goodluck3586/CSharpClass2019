using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_Polymorphism
{
    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");
        }
    }

    class Lion : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("헤엄친다.");
        }
    }

    class Human : Mammal
    {
        override public void Move()
        {
            Console.WriteLine("두 발로 움직인다.");
        }
    }
}
