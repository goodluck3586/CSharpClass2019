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
            int x = Plus(3, 4);
            int y = Plus(5, 6);
            Console.WriteLine(x);
            Console.WriteLine(y);

        }

        static int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
