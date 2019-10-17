using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties01
{
    class Person_GetterSetter
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }
    class Person_Properties
    {
        private string name;

        // name 변수에 값을 저장하거나 가져갈 수 있는 프로퍼티
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;  // set 접근자의 암묵적 매개변수
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person_GetterSetter p1 = new Person_GetterSetter();
            p1.SetName("아이유");
            Console.WriteLine(p1.GetName());

            Person_Properties p2 = new Person_Properties();
            p2.Name = "아이유";
            Console.WriteLine(p2.Name);
        }
    }
}
