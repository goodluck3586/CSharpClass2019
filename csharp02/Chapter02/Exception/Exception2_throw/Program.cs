using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* throw : 명시적 예외 던지기 407p */
namespace Exception2_throw
{
    class Program
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 크네요");

        }

        static void Main(string[] args)
        {
            try
            {
                DoSomething(5);
                DoSomething(11);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
