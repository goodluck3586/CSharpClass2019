using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties03
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "누구?";
        public DateTime Birthday { get; set; } = new DateTime(0001, 1, 1);
        public int Age {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;  } }
        }

    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "아이유";
            birth.Birthday = new DateTime(1993, 5, 16);
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday.ToShortDateString());
            Console.WriteLine(birth.Age);
        }
    }
}
