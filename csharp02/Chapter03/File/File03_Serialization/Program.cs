using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File03_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.BitConverter (직렬화)
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes = BitConverter.GetBytes((short)1023);
            byte[] intBytes = BitConverter.GetBytes(1023);

            // 역직렬화
            bool boolData = BitConverter.ToBoolean(boolBytes, 0);
            short shortData = BitConverter.ToInt16(shortBytes, 0);
            int intData = BitConverter.ToInt32(intBytes, 0);

            Console.WriteLine(BitConverter.ToString(boolBytes));
            Console.WriteLine(BitConverter.ToString(shortBytes));
            Console.WriteLine(BitConverter.ToString(intBytes));

            // MemoryStream
            MemoryStream ms = new MemoryStream();
            ms.Write(shortBytes, 0, shortBytes.Length);
            ms.Write(intBytes, 0, intBytes.Length);

            ms.Position = 0;

            byte[] outBytes = new byte[2];
            ms.Read(outBytes, 0, shortBytes.Length);
            int sData = BitConverter.ToInt16(outBytes, 0);
            Console.WriteLine(sData);
          

        }
    }
}
