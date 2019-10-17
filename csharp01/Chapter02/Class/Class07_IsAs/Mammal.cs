using System;

namespace Class07_IsAs
{
    class Mammal
    {
        protected string name;

        public Mammal(string name)
        {
            this.name = name;
            Console.WriteLine($"생성자 호출: {name}.Mammal()");
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
            Console.WriteLine($"생성자 호출: {name}.Dog()");
        }

        public void Bark()
        {
            Console.WriteLine($"{name}이 멍멍 짖는다.");
        }
    }

    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
            Console.WriteLine($"생성자 호출: {name}.Cat()");
        }

        public void Meow()
        {
            Console.WriteLine($"{name}이 야옹야옹 운다.");
        }
    }
}
