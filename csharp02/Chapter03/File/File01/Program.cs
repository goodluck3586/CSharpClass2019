using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 디렉토리가 존재하지 않으면 삭제, 존재하면 생성
            Console.WriteLine("*****Directory, File*****");
            CreateDirectoryUsingDirectory();

            DirectoryInfo dir = new DirectoryInfo(@"D:\CSharpWorkspace\TestDirectory2");
            dir.Create();
        }

        private static void CreateDirectoryUsingDirectory()
        {
            string path = @"D:\CSharpWorkspace\TestDirectory1";     // 디렉토리 경로

            if (Directory.Exists(path))
            {
                DeleteFileUsingFile(path);
                Directory.Delete(path);
                Console.WriteLine("디렉토리 삭제됨.");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("디렉토리 생성됨.");
                CreateFileUsingFile(path);
                ReadFileUsingFile(path);
            }
         }

        private static void ReadFileUsingFile(string path)
        {
            path = path + @"\TestFile.txt";
            StreamReader sr = File.OpenText(path);
            string line;
            while ((line = sr.ReadLine()) != null){
                Console.WriteLine(line);
            }
            Console.WriteLine("파일 내용 읽음.");
        }

        private static void DeleteFileUsingFile(string path)
        {
            path = path + @"\TestFile.txt";
            File.Delete(path);
            Console.WriteLine("TestFile.txt 파일 삭제됨");
        }

        private static void CreateFileUsingFile(string path)
        {
            path = path + @"\TestFile.txt";
            FileStream fs = File.Create(path);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello World!");
            sw.Close();
            Console.WriteLine("TestFile.txt 파일 생성됨");
        }
    }
}
