using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
/* 600p 예제 */
namespace File06_Serialization
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.txt", FileMode.Create);
            // 객체를 직렬화/역직렬화하는 클래스
            BinaryFormatter serializer = new BinaryFormatter();

            NameCard nc = new NameCard();
            nc.Name = "아이유";
            nc.Phone = "010-444-4444";
            nc.Age = 28;

            // 클래스 직렬화 -> FileStrem에 기록
            serializer.Serialize(ws, nc);  // nc객체를 직렬화하여  ws에 작성
            ws.Close();

            // FileStrem에서 클래스 역직렬화
            Stream rs = new FileStream("a.txt", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);
            rs.Close();

            Console.WriteLine(nc2.Name);
            Console.WriteLine(nc2.Phone);
            Console.WriteLine(nc2.Age);
        }
    }
}
