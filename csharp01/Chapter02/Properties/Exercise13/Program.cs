using System;
using System.Numerics;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "아이유", Age = 27 };
            Console.WriteLine("이름: {0}, 나이: {1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = 12, Imaginary = 15 };
            Console.WriteLine("complex: {0} + {1}i", complex.Real, complex.Imaginary);
        }
    }
}
