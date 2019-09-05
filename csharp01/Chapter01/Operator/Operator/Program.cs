using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Foo
    {
        public int member = 100;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Null 조건부 연산자
            Foo foo = new Foo();

            int? bar;  // Nullable 변수 선언: null 을 저장할 수 있는 변수가 됨.
            //if (foo == null)
            //    bar = null;
            //else
            //    bar = foo.member;
            bar = foo?.member;  // foo가 null이 아니면 member 변수값 할당, 아니면 null

            Console.WriteLine(bar);

            ArrayList arr = null;
            arr?.Add("야구");
            arr?.Add("축구");
            Console.WriteLine(arr?.Count);
            Console.WriteLine(arr?[0]);
            Console.WriteLine(arr?[1]);

            arr = new ArrayList();
            arr?.Add("야구");
            arr?.Add("축구");
            Console.WriteLine(arr?.Count);
            Console.WriteLine(arr?[0]);
            Console.WriteLine(arr?[1]);

            int? a = null;
            Console.WriteLine($"{a  ?? 0}");

            a = 100;
            Console.WriteLine($"{a ?? 0}");
        }
    }
}
