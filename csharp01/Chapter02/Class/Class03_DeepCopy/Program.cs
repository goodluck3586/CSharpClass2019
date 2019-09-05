using System;

/* 얕은 복사, 깊은 복사 */
namespace Class03_DeepCopy
{
    class MyClass
    {
        public int field1;
        public int field2;

        public MyClass ClassDeepCopy()
        {
            MyClass copyObject = new MyClass();
            copyObject.field1 = this.field1;
            copyObject.field2 = this.field2;
            return copyObject;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("얕은 복사");
            {
                MyClass source = new MyClass();
                source.field1 = 10;
                source.field2 = 20;

                MyClass target = source;
                target.field2 = 30;

                Console.WriteLine($"{source.field1}, {source.field2}");  // 10, 30
                Console.WriteLine($"{target.field1}, {target.field2}");  // 10, 30
            }

            Console.WriteLine("깊은 복사");
            {
                MyClass source = new MyClass();
                source.field1 = 10;
                source.field2 = 20;

                MyClass target = source.ClassDeepCopy();
                target.field2 = 30;

                Console.WriteLine($"{source.field1}, {source.field2}");  // 10, 20 
                Console.WriteLine($"{target.field1}, {target.field2}");  // 10, 30
            }
        }
    }
}
