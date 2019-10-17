using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // 명명되지 않은 튜플
            var tuple = (123, 3.14f);
            Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");

            // 명명된 튜플
            var tuple2 = (Name: "아이유", Age: 28);
            Console.WriteLine($"{tuple2.Name}, {tuple2.Age}");

            // 분해
            var (name, age) = tuple2;
            Console.WriteLine($"{name}, {age}");

            // 명명된 튜플 = 명명되지 않은 튜플
            tuple2 = ("최다원", 18);
            Console.WriteLine($"{tuple2.Name}, {tuple2.Age}");

        }
    }
}
