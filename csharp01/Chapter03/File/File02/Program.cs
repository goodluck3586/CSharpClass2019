using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 575p 예제 */
namespace File02
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = ".";  // 현재 디렉토리
            else
                directory = args[0];  // 사용자가 입력한 경로 저장

            Console.WriteLine($"{directory} directory info");
            Console.WriteLine("- Directories : ");

            foreach (var item in Directory.GetDirectories(directory))
            {
                Console.WriteLine(item);
            }

            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)   // let은 LINQ안의 var
                               select new { Name = info.Name, Attribute = info.Attributes }).ToList();

            foreach (var d in directories)
                Console.WriteLine($"{d.Name} : {d.Attribute}");

            Console.WriteLine("- Files : ");
            // 쿼리 만들기
            var files = from file in Directory.GetFiles(directory)
                        let info = new FileInfo(file)
                        select new { Name = info.Name, FileSize = info.Length, Attribute = info.Attributes };

            // 쿼리 실행
            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name}, {item.FileSize}, {item.Attribute}");
            }
        }
    }
}
