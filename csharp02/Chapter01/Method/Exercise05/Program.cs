using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 개의 정수 n과 m (n <= m)이 주어지면, [n, m] 범위의 합계와 평균을 출력 */
/* 출력 결과: SumAndAverage(11, 66) → "Sum: 2156, Average: 38.5" */
namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAndAverage(11, 66);
        }

        static void SumAndAverage(int a, int b)
        {
            int sum = 0;
            float average;

            for(int i=a; i<=b; i++)
            {
                sum += i;
            }
            average = sum / (float)(b - a + 1);

            Console.WriteLine($"Sum: {sum}, Average: {average}");
        }
    }
}
