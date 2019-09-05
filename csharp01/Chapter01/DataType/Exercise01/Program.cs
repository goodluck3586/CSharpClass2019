using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 두 개 입력: ");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            double num1 = double.Parse(n1);
            double num2 = double.Parse(n2);
            Console.WriteLine("{0] + {1} = {2}", num1, num2, num1+num2);
        }
    }
}
