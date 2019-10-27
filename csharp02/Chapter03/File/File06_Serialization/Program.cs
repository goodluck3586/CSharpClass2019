using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
/* 600p 객체 직렬화/역직렬화 */
namespace File06_Serialization
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

            NameCard nameCard = new NameCard("아이유", "444-4444", 28);
            serializer.Serialize(ws, nameCard);  // nameCard 객체를 직렬화해서 FileStream에 기록
            ws.Close();

            // 객체 역직렬화
            Stream rs = new FileStream("a.txt", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nameCard2;
            nameCard2 = deserializer.Deserialize(rs) as NameCard;
            //nameCard2 = (NameCard)deserializer.Deserialize(rs);
            rs.Close();

            Console.WriteLine(nameCard2.Name);
            Console.WriteLine(nameCard2.Phone);
            Console.WriteLine(nameCard2.Age);
        }
    }
}
