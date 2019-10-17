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
            // 디렉토리가 존재하지 않으면 생성하고, 존재하면 삭제
            //CreateDirectoryUsingDirectory();
            CreateDirectoryUsingDirectoryInfo();
        }

        #region Directory, File 클래스
        private static void CreateDirectoryUsingDirectory()
        {
            string path = @"D:\CSharpWorkspace\TestDirectory";

            if (Directory.Exists(path))  // 디렉토리 존재 유무 확인
            {
                DeleteFileUsingFile(path);
                Directory.Delete(path);  // 디렉토리 삭제
                Console.WriteLine($"디렉토리 삭제함. {path} ");
            }
            else
            {
                Directory.CreateDirectory(path);  // 디렉토리 생성
                Console.WriteLine($"디렉토리 생성함. {path} ");
                CreateFileUsingFile(path);  //  파일 생성
            }
        }

        private static void DeleteFileUsingFile(string path)
        {
            path = path + @"\Test.txt";
            File.Delete(path);
            Console.WriteLine($"파일 삭제됨. {path}");
        }

        private static void CreateFileUsingFile(string path)
        {
            path = path + @"\Test.txt";
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Hello");
                sw.WriteLine("File");
                sw.Close();

                Console.WriteLine($"파일 생성됨. {path}");
            }

        }
        #endregion

        #region DirectoryInfo, FileInfo 클래스
        private static void CreateDirectoryUsingDirectoryInfo()
        {
            string dirPath = @"D:\CSharpWorkspace\TestDirectoryInfo";  // 디렉토리 경로
            string filePath = dirPath + @"\TestInfo.txt";

            // 객체 생성
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            FileInfo fileInfo = new FileInfo(filePath);

            // Directory.Exists(path)
            if (dirInfo.Exists)  // 디렉토리가 존재하면 삭제, 없으면 생성
            {
                DeleteFileUsingFileInfo(fileInfo);  // 파일 삭제
                dirInfo.Delete();  // 디렉토리 삭제
                Console.WriteLine($"디렉토리 삭제됨. {dirPath}");
            }
            else
            {
                dirInfo.Create();  // 디렉토리 생성
                Console.WriteLine($"디렉토리 생성됨. {dirPath}");
                CreateFileUsingFileInfo(fileInfo);  // 파일 생성
                ReadFileUsingFileInfo(fileInfo);
            }
        }

        private static void ReadFileUsingFileInfo(FileInfo fileInfo)
        {
            StreamReader sr = fileInfo.OpenText();
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
            Console.WriteLine($"파일 내용 읽음. {fileInfo.FullName}");
        }

        private static void DeleteFileUsingFileInfo(FileInfo fileInfo)
        {
            fileInfo.Delete();
            Console.WriteLine($"파일 삭제됨.  {fileInfo.FullName}");
        }

        private static void CreateFileUsingFileInfo(FileInfo fileInfo)
        {
            StreamWriter sw = fileInfo.CreateText();
            sw.WriteLine("안녕하세요.");
            sw.WriteLine("내일은 축제~~");
            sw.Close();

            Console.WriteLine($"파일 생성됨. {fileInfo.FullName}");
        }
        #endregion


    }
}
