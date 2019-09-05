using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 상수, 열거형, Nullable 형식, var
 */

namespace DataType04
{
    class Program
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat}
        static void Main(string[] args)
        {
            /****** 상수 ******/
            const double pi = 3.141592;

            /****** 열거형(enum) : 명명된 상수 집합 ******/
            Day day = Day.Wed;
            Console.WriteLine(day);
            Console.WriteLine("{0}, {0:d}", day);
            Console.WriteLine((int)Day.Fri);

            Console.WriteLine("요일에 해당하는 숫자(일:0, 월:1)를 입력하시오");
            int n = int.Parse(Console.ReadLine());
            WhatDayUsingNum(n);
            WhatDayUsingEnum((Day)n);

            /****** Nullable ******/
            int? num = null;
            Console.WriteLine(num.HasValue);  // false

            num = 100;
            Console.WriteLine(num.HasValue);  // true

            /****** var ******/
            var a = 3;
            var b = "hello";
            var c = 3.14f;

            Console.WriteLine("a: {0}", a.GetType());
            Console.WriteLine("b: {0}", b.GetType());
            Console.WriteLine("c: {0}", c.GetType());
        }

        static void WhatDayUsingNum(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }

        static void WhatDayUsingEnum(Day d)
        {
            switch (d)
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
                    Console.WriteLine("Thursday");
                    break;
                case Day.Fri:
                    Console.WriteLine("Friday");
                    break;
                case Day.Sat:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
