using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 파일을 복사하고, 복사된 글자의 개수를 반환 */
namespace Task09_AsyncAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // 파일 준비
            string path = ".";
            CreateFile(path + @"\source.txt");

            // 1. 동기식 파일 읽기
            CopyFileSync(path + @"\source.txt", path + @"\target1.txt");

            // 2. 비동기식 파일 읽기(비동기 API 사용)
            CopyFileAsync(path + @"\source.txt", path + @"\target2.txt");

            Console.WriteLine("메인 메소드 종료");
        }

        private static async Task CopyFileAsync(string fromPath, string toPath)
        {
            using (StreamReader sr = new StreamReader(fromPath))  // source.txt
            {
                using (StreamWriter sw = new StreamWriter(toPath))  // target.txt
                {
                    string data;
                    data = await sr.ReadToEndAsync();
                    await sw.WriteAsync(data);
                }
            }
        }

        private static void CopyFileSync(string fromPath, string toPath)
        {
            using(StreamReader sr = new StreamReader(fromPath))  // source.txt
            {
                using(StreamWriter sw = new StreamWriter(toPath))  // target.txt
                {
                    string data;
                    data = sr.ReadToEnd();
                    sw.Write(data);
                }
            }
        }

        private static void CreateFile(string path)
        {
            using(StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.Write("Hello World");
            }
        }
    }
}
