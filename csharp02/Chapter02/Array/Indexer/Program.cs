using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Indexer(마치 객체를 배열처럼 사용) */
namespace Indexer
{
    class MyList
    {
        private int[] array = new int[5];

        public int this[int index]
        {
            get { return array[index]; }
            set {
                if(index >= array.Length)
                    Console.WriteLine("index가 범위를 벗어남.");
                else
                    array[index] = value;  // value: set 접근자의 암묵적 매개변수
            }  
        }

        public int Length  // myList.Length
        {
            get { return array.Length; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList[0] = 1;
            myList[1] = 2;
            for (int i = 0; i < 6; i++)
                myList[i] = i;

            for (int i = 0; i < myList.Length; i++)
                Console.WriteLine($"{myList[i]} "); 
        }
    }
}
