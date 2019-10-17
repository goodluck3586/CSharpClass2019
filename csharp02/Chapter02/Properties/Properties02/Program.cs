using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties02
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
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "아이유";
            birth.Birthday = new DateTime(1993, 5, 16);

            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Name: {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Name: {birth.Age}");
        }
    }
}
