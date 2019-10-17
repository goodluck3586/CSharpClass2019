using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 인터페이스 다중 상속 */
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

            IRunnable runable = car;
            runable.Run();

            IFlyable flyable = new FlyingCar();
            flyable.Fly();

            FlyingCar car2 = flyable as FlyingCar;
            car2.Run();
            car2.Fly();
        }
    }
}
