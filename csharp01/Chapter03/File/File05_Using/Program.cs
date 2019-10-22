using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File05_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            // 리소스를 사용한 다음에는 닫아줘야 한다.
            FileStream fs1 = new FileStream("test1.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1, Encoding.UTF8);
            sw1.WriteLine("Hello C#");
            sw1.Close();
            fs1.Close();

            // using문은 리소스의 범위를 한정한다.
            using(FileStream fs2 = new FileStream("test2.txt", FileMode.Create))
            {
                using(StreamWriter sw2 = new StreamWriter(fs2, Encoding.UTF8))
                {
                    sw2.WriteLine("Hello C#");
                }
            }
        }
    }
}
