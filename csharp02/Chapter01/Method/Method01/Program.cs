using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y=20;
            Console.WriteLine(Plus(x, y));
            Console.WriteLine(Minus(x, y));

            int Minus(int a, int b)
            {
                return a - b;
            }
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
