using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * object 형식, boxing, unboxing
 */
namespace DataType02
{
    class Program
    {
        static void Main(string[] args)
        {
            /***** object 형식 *****/
            // object는 모든 형식의 부모이다.
            object a = 100;
            object b = 3.141592;
            object c = true;
            object d = "Hello World";

            Console.WriteLine("{0}, : {1}", a, a.GetType());
            Console.WriteLine("{0}, : {1}", b, b.GetType());
            Console.WriteLine("{0}, : {1}", c, c.GetType());
            Console.WriteLine("{0}, : {1}", d, d.GetType());


            /***** boxing, unboxing *****/

            int i = 123;   
            object o = i;   // boxing
            int j = (int)o; //unboxing

            // Console.WriteLine(i+o);
            Console.WriteLine(i + (int)o);

            double e = 2.9023865982346;
            double f = e;
            object o1 = e;
            object o2 = f;

            int num = (int)(double)o1;

            Console.WriteLine(e==f);
            Console.WriteLine(o1==o2);
            Console.WriteLine((double)o1 == (double)o2);
        }
    }
}
