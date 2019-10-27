using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
/* 601p 예제 */
namespace File07_SerializationCollection
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;

        public NameCard(string name, string phone, int age)
        {
            Name = name;
            Phone = phone;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 객체 직렬화
            Stream ws = new FileStream("a.txt", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();   // 객체를 직렬화하는 클래스

            List<NameCard> list = new List<NameCard>();
            list.Add(new NameCard("아이유", "111", 28));
            list.Add(new NameCard("구천성", "222", 22));
            list.Add(new NameCard("피오", "333", 21));

            serializer.Serialize(ws, list);  // nameCard 객체를 직렬화해서 FileStream에 기록
            ws.Close();

            // 객체 역직렬화
            Stream rs = new FileStream("a.txt", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = deserializer.Deserialize(rs) as List<NameCard>;
            //nameCard2 = (NameCard)deserializer.Deserialize(rs);
            rs.Close();

            foreach (var item in list2)
            {
                Console.WriteLine($"{item.Name}, {item.Phone}, {item.Age}");
            }
        }
    }
}
