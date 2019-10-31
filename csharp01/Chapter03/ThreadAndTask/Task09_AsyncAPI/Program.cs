using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 파일을 복사하고, 파일의 크기를 반환한다.
namespace Task09_AsyncAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\CSharpWorkspace";

            // 파일 생성 및 텍스트 기록
            CreateFile(path + @"\source.txt");

            #region 동기식 파일 복제
            // 1. StreamReader, StreamWriter 사용
            Console.WriteLine(CopySync(path + @"\source.txt", path + @"\target1.txt"));
            #endregion

            #region 비동기식 파일 복제
            // 1. StreamReader, StreamWriter 사용
            Task<int> copyTask = CopyAsync(path + @"\source.txt", path + @"\target2.txt");
            var copyTask2 = CopyAsync(path + @"\source.txt", path + @"\target3.txt");
            #endregion

            Console.WriteLine("메인 스레드 종료");
            Console.WriteLine($"Copied Total: {copyTask.Result} Bytes");
            Console.WriteLine($"Copied Total: {copyTask2.Result} Bytes");
        }

        async private static  Task<int> CopyAsync(string fromPath, string toPath)
        {
            using(var sr = new StreamReader(fromPath))
            {
                using (var sw = new StreamWriter(toPath))
                {
                    string line;
                    line = await sr.ReadToEndAsync();
                    await sw.WriteAsync(line);
                    return line.Length;
                }
            }
        }

        private static int CopySync(string fromPath, string toPath)
        {
            using(StreamReader sr = new StreamReader(fromPath))  // source.txt
            {
                using(StreamWriter sw = new StreamWriter(toPath))  // target1.txt
                {
                    string line;
                    line = sr.ReadToEnd();
                    sw.Write(line);
                    return line.Length;  // 복사한 글자 길이 반환
                }
            }
        }

        private static void CreateFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.Write("Hello World");
            }

        }
    }
}
