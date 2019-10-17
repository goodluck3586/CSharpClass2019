using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 식으로 이루어진 멤버 : {}를 람다식으로 표현 */
/* 476p 예제 */
namespace Lambda03_ExpressionMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        // {}를 람다식으로 대체 가능
        //public void Add(string name){ list.Add(name); }
        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var name in list)
                Console.WriteLine(name);
        }

        public FriendList() => Console.WriteLine("FriendList()");  // 생성자
        ~FriendList() => Console.WriteLine("~FriendList()");  // 소멸자

        //public int Capacity => list.Capacity;
        public int Capacity
        {
            get => list.Capacity; 
            set => list.Capacity = value;
        }

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
            obj.Add("구천성");
            obj.Add("산체스");
            obj.Remove("구천성");
            obj.PrintAll();

            Console.WriteLine(obj.Capacity);
            obj.Capacity = 10;
            Console.WriteLine(obj.Capacity);

            Console.WriteLine(obj[0]);
            obj[0] = "오늘 일찍 끝난다.";
            obj.PrintAll();
        }
    }
}
