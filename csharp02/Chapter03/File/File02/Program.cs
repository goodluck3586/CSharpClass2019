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
            string dirPath;
            if (args.Length < 1)
                dirPath = ".";
            else
                dirPath = args[0];

            Console.WriteLine(" *** Directories : ");
            var diredctories = (from dir in Directory.GetDirectories(dirPath)
                                let info = new DirectoryInfo(dir)  // let : LINQ 안에서 사용하는 var
                                select new { Name = info.Name, Attributes = info.Attributes }).ToList();

            foreach (var item in diredctories)
            {
                Console.WriteLine($"{item.Name}, {item.Attributes}");
            }

            Console.WriteLine(" *** Files : ");
            var files = from file in Directory.GetFiles(dirPath)
                        let info = new FileInfo(file)  // let : LINQ 안에서 사용하는 var
                        select new
                        {
                            Name = info.Name,
                            FileSize = info.Length,
                            Attributes = info.Attributes
                        };

            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name}, {item.FileSize}, {item.Attributes}");
            }
        }
    }
}
