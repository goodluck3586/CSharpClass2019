using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 피보나치 수열 출력하기(반복문, 재귀호출) */
namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopCount = 45;

            Console.WriteLine("재귀호출을 이용한 피보나치 수열 출력");
            for (int i = 0; i <= loopCount; i++)
            {
                Console.WriteLine($"FibonacciRecursive({i:d2}) : {FibonacciRecursive(i)}");
            }

            Console.WriteLine('\n');

            Console.WriteLine("반복문을 이용한 피보나치 수열 출력");
            for(int i=0; i<=loopCount; i++)
            {
                Console.WriteLine($"FibonacciLoop({i:d2}) : {FibonacciLoop(i)}");
            }
        }

        static int FibonacciLoop(int n)
        {
            int v1 = 0, v2 = 1, returnValue = 0;
            for(int i=0; i<n; i++)
            {
                returnValue = v2;
                v2 = v1 + v2;
                v1 = returnValue;
            }
            return returnValue;
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
