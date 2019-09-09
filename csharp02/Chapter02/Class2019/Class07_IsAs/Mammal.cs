using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_IsAs
{
    class Mammal
    {
        protected string name;

        public Mammal(string name)
        {
            this.name = name;
            Console.WriteLine($"Mammal({name})생성자 호출");
        }

        public string GetName()
        {
            return name;
        }
    }

    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine($"Dog({name})생성자 호출");
        }

        public void Bark()
        {
            Console.WriteLine($"{name}가 멍멍 짖는다.");
        }
    }

    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
            Console.WriteLine($" Cat({name})생성자 호출");
        }

        public void Meow()
        {
            Console.WriteLine($"{name}가 야옹야옹 운다.");
        }
    }
}
