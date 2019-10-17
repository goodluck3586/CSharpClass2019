using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 일반화 클래스 */
namespace GenericClass1
{
    class Array_int
    {
        private int[] array = new int[5];
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }

    class Array_double
    {
        private double[] array = new double[5];
        public double this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }

    class Array_Generic<T>
    {
        private T[] array = new T[5];
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Array_int a1 = new Array_int();
            a1[0] = 100;

            Array_Generic<int> g1 = new Array_Generic<int>();
            g1[0] = 100;

            Array_Generic<double> g2 = new Array_Generic<double>();
            g2[0] = 100;
        }
    }
}
