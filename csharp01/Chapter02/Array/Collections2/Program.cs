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

            // 배열을 이용한 큐 초기화
            object[] arr = new object[] { 1, 3.14, 'A', "Queue" };
            Queue q2 = new Queue(arr);
            PrintQueue(q2);

            Queue q3 = new Queue(new object[] { 1, 3.14, 'A', "Queue" });
            PrintQueue(q3);
            #endregion

            #region System.Collections.Generic.Queue
            Queue<int> gq = new Queue<int>();
            for (int i = 0; i <= 5; i++)
                gq.Enqueue(i);

            PrintQueue2(gq);
            PrintQueue2(gq);
            #endregion
        }

        private static void PrintQueue2(Queue<int> gq)
        {
            while(gq.Count>0)
                Console.Write($"{gq.Dequeue()} ");
            Console.WriteLine();
        }

        private static void PrintQueue(Queue q)
        {
            while(q.Count>0)
                Console.Write($"{q.Dequeue()} ");
            Console.WriteLine();
        }
    }
}
