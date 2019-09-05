using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 가변길이 매개변수 params, 명명된 매개변수 */
namespace Method04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 가변길이 매개변수 */
            int sum = Sum(1,2,3);
            Console.WriteLine($"sum = {sum}");
            sum = Sum(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine($"sum = {sum}");

            /* 명명된 매개변수 */
            PrintProfile(name: "손흥민", phone: "010-123-4567");

            /* 선택된 매개변수 */
            PrintProfile("아이유");
        }

        static int Sum(params int[] args)
        {
            int sum = 0;
            foreach(int i in args)
            {
                sum += i;
            }
            return sum;
        }

        static void PrintProfile(string name, string phone = "번호를 모름")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
    }
}
