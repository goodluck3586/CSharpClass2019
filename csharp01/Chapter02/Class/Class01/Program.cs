using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.name = "키티";
            kitty.color = "하얀색";
            kitty.Meow();
            Console.WriteLine($"{kitty.name}, {kitty.color}");

            Cat nero = new Cat();
            nero.name = "네로";
            nero.color = "검정색";
            nero.Meow();
            Console.WriteLine($"{nero.name}, {nero.color}");

            Cat nabi = new Cat("나비", "갈색");
            nabi.Meow();
            Console.WriteLine($"{nabi.name}, {nabi.color}");
        }
    }
}
