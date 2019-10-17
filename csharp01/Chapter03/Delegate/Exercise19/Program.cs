using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    delegate T AreaDelegate<T>(T w, T h);
    class ShapeArea
    {
        public void PrintShapeArea<T>(string name, T a, T b, AreaDelegate<T> areaDelegate)
        {
            Console.WriteLine($"{name} 도형의 넓이 : {areaDelegate(a, b)}");
        }
    }
    class Program
    {
        static T RectangleArea<T>(T a, T b) where T : int
        {
            return a * b;
        }
        static void Main(string[] args)
        {
           
        }
    }
}
