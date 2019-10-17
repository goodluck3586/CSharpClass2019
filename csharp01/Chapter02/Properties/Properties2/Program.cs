using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 이것이 C#이다. 310쪽 예제 */
namespace Properties2
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo b1 = new BirthdayInfo();
            b1.Name = "아이유";
            b1.Birthday = new DateTime(1993, 5, 16);

            Console.WriteLine(DateTime.Now.Subtract(b1.Birthday).Ticks);
            Console.WriteLine(new DateTime(0001, 1, 1, 12, 1, 1).Ticks);
            Console.WriteLine(new DateTime(0001, 1, 1, 12, 1, 2).Ticks);
            Console.WriteLine(new DateTime(432620000000));

            Console.WriteLine($"Name: {b1.Name}");
            Console.WriteLine($"Birthday: {b1.Birthday}");
            Console.WriteLine($"Age: {b1.Age}");
        }
    }
}
