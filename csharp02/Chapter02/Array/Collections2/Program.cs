using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Queue(First In First Out) */
namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region System.Collections.Queue
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(3.14);
            q.Enqueue('A');
            q.Enqueue("Queue");
            PrintQueue(q);

            // 큐의 초기화(배열 이용)
            object[] arr = new object[] { 1, 3.14, 'A', "Queue" };
            Queue q2 = new Queue(arr);
            PrintQueue(q2);

            Queue q3 = new Queue(new object[] { 1, 3.14, 'A', "Queue" });
            PrintQueue(q3);
            #endregion

            #region System.Collections.Generic.Queue
            Queue<int> gq = new Queue<int>();
            for (int i = 1; i < 6; i++)
                gq.Enqueue(i);

            while(gq.Count>0)
                Console.Write($"{gq.Dequeue()} ");
            Console.WriteLine('\n');
            #endregion
        }

        private static void PrintQueue(Queue q)
        {
            while(q.Count>0)
                Console.Write($"{q.Dequeue()} ");
            Console.WriteLine('\n');
        }
    }
}
