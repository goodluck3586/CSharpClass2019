using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Dog("멍멍이");
            Mammal m2 = new Cat("야옹이");

            if(m1 is Dog)  // 같은 클래스 타입이면 true
            {
                Dog dog = (Dog)m1;
                dog.Bark();
            }

            // Cat cat = (Cat)m1;  // 타입이 맞지 않아 에러 발생
            // Cat cat = m1 as Cat;  // 타입이 맞지 않는 경우 null 발생
            Cat cat = m2 as Cat;
            if(cat != null)
            {
                cat.Meow();
            }

            Wash(new Dog("푸드리"));
            Wash(new Cat("길냥이"));

        }

        static void Wash(Mammal mammal)
        {
            Console.WriteLine($"{mammal.GetName()}가 씻는다.");
        }
    }
}
