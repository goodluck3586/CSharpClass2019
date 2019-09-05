using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 상수, 열거형, Nullable, var
 */
namespace DataType04
{
    class Program
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            /***** 상수 *****/
            const double pi = 3.141592;


            /***** 열거형(enum): 상수 집합 *****/
            Day today = Day.Mon;
            Console.WriteLine("today: {0}", today);
            Console.WriteLine((int)Day.Sun);
            Console.WriteLine((int)Day.Mon);
            Console.WriteLine((Day)0);

            Console.WriteLine("요일을 숫자(일:0, 월:1)로 입력하시오.");
            string input = Console.ReadLine();

            switch((Day)int.Parse(input))
            {
                case Day.Sun:
                    Console.WriteLine("Sunday");
                    break;
                case Day.Mon:
                    Console.WriteLine("Monday");
                    break;
                case Day.Tue:
                    Console.WriteLine("Tuesday");
                    break;
                case Day.Wed:
                    Console.WriteLine("Wednesday");
                    break;
                case Day.Thu:
                    Console.WriteLine("Thurday");
                    break;
                case Day.Fri:
                    Console.WriteLine("Friday");
                    break;
                case Day.Sat:
                    Console.WriteLine("Saturday");
                    break;
            }

            /***** Nullable 형식 *****/
            int? n = null;

            Console.WriteLine(n.HasValue);  // False

            n = 100;
            Console.WriteLine(n.HasValue);  // True


            /***** var *****/
            var a = 3;
            var b = "hello";
            var c = 3.14;

            Console.WriteLine("a: {0}", a.GetType());
            Console.WriteLine("b: {0}", b.GetType());
            Console.WriteLine("c: {0}", c.GetType());
        }
    }
}
