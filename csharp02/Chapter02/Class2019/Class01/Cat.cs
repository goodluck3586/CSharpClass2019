using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
{
    class Cat
    {
        public string name;
        public string color;

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }

        public Cat()
        {

        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
