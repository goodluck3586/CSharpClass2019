using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1. 클래스에서 이벤트(콜백)를 제공한다.
* 2. 외부에서 자유롭게 해당 이벤트(콜백)을 구독하거나 해지하는 것이 가능하다.
* 3. 외부에서 구독/해지는 가능하지만 이벤트 발생은 오직 클래스 내부에서만 가능하다.
* 4. 이벤트(콜백)의 첫 번째 인자로는 이벤트를 발생시킨 타입의 인스턴스이다.
* 5. 이벤트(콜백)의 두 번째 인자로는 해당 이벤트에 속한 의미 있는 값이 제공된다.
*/

/* delegate로 구현(1~n까지 값을 진행하면서 소수라고 판정될 때마다 콜백을 발생시키는 클래스) */
namespace Event02_delegate
{
    class CallbackArg { } // 콜백의 값을 담는 클래스의 최상위 부모 클래스 역할
    class PrimeCallbackArg : CallbackArg // 콜백 값을 담는 클래스 정의
    {
        public int Prime;
        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    // 소수 생성기: 소수가 발생할 때마다 등록된 콜백 메서드를 호출
    class PrimeGenerator
    {
        // 콜백을 위한 델리게이트 타입 정의
        public delegate void PrimeDelegate(object sender, CallbackArg arg);

        // 콜백 메서드를 보관하는 델리게이트 인스턴스 필드
        PrimeDelegate callbacks;

        // 콜백 메서드 추가
        public void AddDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
            //callbacks += callback;
        }

        // 콜백 메서드 삭제
        public void RemoveDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Remove(callbacks, callback) as PrimeDelegate;
        }

        // 주어진 수까지 루프를 돌면서 소수가 발견되면 콜백 메서드 호출
        public void Run(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i) == true && callbacks != null)
                {
                    // 콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                    callbacks(this, new PrimeCallbackArg(i));
                }
            }
        }

        /* num이 소수이면 true, 아니면 false */
        private bool IsPrime(int num)
        {
            if (num == 2)
                return true;

            for (int i = 2; i <= num / 2; i++)
            {
                if ((num % i) == 0)
                    return false;
            }
            return true;
        }
    }

    class Program
    {
        static int sum;

        // 콜백으로 등록될 메서드 1
        static void PrintPrime(object sender, CallbackArg arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + " ");
        }

        // 콜백으로 등록될 메서드 2
        static void SumPrime(object sender, CallbackArg arg)
        {
            sum += (arg as PrimeCallbackArg).Prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            // PrintPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callprint = PrintPrime;
            gen.AddDelegate(callprint);

            // SumPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callsum = SumPrime;
            gen.AddDelegate(callsum);

            // 1~10까지의 소수를 구하고,
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(sum);

            // SumPrime 메서드를 제거한 후, 다시 1~15까지 소수를 구하는 메서드 호출
            gen.RemoveDelegate(callsum);
            gen.Run(15);
        }
    }
}