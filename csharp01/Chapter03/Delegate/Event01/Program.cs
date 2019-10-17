using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 449p 예제 */
namespace Event01
{
    delegate void EventHandler(string messge);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) 
                SomethingHappened(String.Format("{0} : 짝", number));
        }
    }

    class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 0; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
