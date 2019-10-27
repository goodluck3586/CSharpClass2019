using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* using문 : 리소스의 유효범위 지정 */
namespace File05_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            // using문을 사용하지 않는 경우
            FileStream fs1 = new FileStream("test1.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1, Encoding.UTF8);
            sw1.WriteLine("안녕하세요..");
            sw1.Close();
            fs1.Close();

            // using문을 사용하는 경우
            using (FileStream fs2 = new FileStream("test2.txt", FileMode.Create))
            {
                using(StreamWriter sw2 = new StreamWriter(fs2, Encoding.UTF8))
                {
                    sw2.WriteLine("Hello World!!!");
                }
            }

        }
    }
}
