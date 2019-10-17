using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 여러 개의 인터페이스 한꺼번에 상속하기 */
namespace Interface5
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly Fly");
        }

        public void Run()
        {
            Console.WriteLine("Run Run");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car;
            runnable.Run();

            IFlyable flyable = (IFlyable)car;
            flyable.Fly();
        }
    }
}
