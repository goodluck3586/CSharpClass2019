using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Try Catch */
namespace Exception1_TryCatch
{
    class Program
    {
        static int[] arr = { 1, 2, 3 };

        static void ExceptionMethod()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine("ExceptionMethod() 종료");
        }

        static void TryCatchMethod()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(arr[i]);
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("TryCatchMethod() 종료");
        }

        static void Main(string[] args)
        {
            //ExceptionMethod();
            TryCatchMethod();
        }
    }
}
