using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 476p 예제 */
namespace Lambda03_ExpressionMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);  // 메소드를 식으로 표현
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        // 생성자를 식으로 표현
        public FriendList() => Console.WriteLine("FriendList()");
        // 소멸자를 식으로 표현
        ~FriendList() => Console.WriteLine("~FriendList()");

        //public int Capacity => list.Capacity;  // 프로퍼티를 식으로 표현
        public int Capacity
        {
            get { return list.Capacity; }
            set => list.Capacity = value;
        }

        //public string this[int index] => list[index];
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("아이유");
            obj.Add("장만월");
            obj.Add("이선균");
            obj.Add("현승이");
            obj.Remove("장만월");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine(obj[0]);
            obj[0] = "홍하연";
            obj.PrintAll();

        }
    }
}
