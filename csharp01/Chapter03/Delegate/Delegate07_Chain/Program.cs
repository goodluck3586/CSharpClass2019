using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 440p 예제 */
namespace Delegate07_Chain
{
    delegate void Notify(string msg);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappened(string msg)
        {
            Console.WriteLine($"{name}.SomethingHappened : {msg}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappened;
            notifier.EventOccured += listener2.SomethingHappened;
            notifier.EventOccured += listener3.SomethingHappened;
            notifier.EventOccured("You've got mail.");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappened;
            notifier.EventOccured("Download complete.");

            notifier.EventOccured = new Notify(listener2.SomethingHappened) + new Notify(listener3.SomethingHappened);
            notifier.EventOccured("Nuclear launch detected.");
            Console.WriteLine();

        }
    }
}
