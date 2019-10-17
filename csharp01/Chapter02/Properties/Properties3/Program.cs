using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 자동 구현 프로퍼티 */
namespace Properties3
{
    class NameCard1
    {
        private string name;
        private string phoneNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }

    class NameCard2  // 자동 구현 프로퍼티
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    class NameCard3  // 자동 구현 프로퍼티
    {
        public string Name { get; set; } = "Unknown";
        public string PhoneNumber { get; set; } = "000-000-0000";
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCard1 n1 = new NameCard1();
            n1.Name = "박보검";
            Console.WriteLine(n1.Name);

            NameCard2 n2 = new NameCard2();
            n2.Name = "장만월";
            Console.WriteLine(n2.Name);

            NameCard3 n3 = new NameCard3();
            Console.WriteLine(n3.Name);

            NameCard2 n4 = new NameCard2()
            {
                Name = "아이유",
                PhoneNumber = "010-111-2222"
            };
            Console.WriteLine(n4.Name);
        }
    }
}
