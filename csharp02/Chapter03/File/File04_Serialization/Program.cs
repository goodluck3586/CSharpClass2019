using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File04_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\CSharpWorkspace\TestFile1.txt";

            #region FileStream으로 데이터 읽고 쓰기
            FileStream fs = new FileStream(path, FileMode.Create);
            byte[] buffer = Encoding.UTF8.GetBytes("Hello World");
            fs.Write(buffer, 0, buffer.Length);
            Console.WriteLine(fs.Position);

            fs.Position = 0;
            byte[] readBuf = new byte[buffer.Length];
            fs.Read(readBuf, 0, buffer.Length);
            UTF8Encoding temp = new UTF8Encoding();
            Console.WriteLine(temp.GetString(readBuf));
            fs.Close();
            #endregion

            #region StreamWriter, StreamReader로 데이터 읽고 쓰기
            FileStream fileStream = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fileStream);
            sw.WriteLine("안녕하세요 ^^");
            sw.WriteLine("안녕하세요 ^^");
            sw.WriteLine("안녕하세요 ^^");
            sw.Close();

            StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open));
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            #endregion
        }
    }
}
