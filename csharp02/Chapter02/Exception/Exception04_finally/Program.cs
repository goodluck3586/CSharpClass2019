﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 412p 예제 */
namespace Exception04_finally
{
    class Program
    {
        static int Divide(int divisor, int dividend)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide()에서 에러 발생");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 종료");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("나누어지는 수를 입력하세요 : ");
                int dividend = Convert.ToInt32(Console.ReadLine());

                Console.Write("나누는 수를 입력하세요 : ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{dividend}/{divisor}={Divide(dividend, divisor)}");
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료.");
            }
        }
    }
}
