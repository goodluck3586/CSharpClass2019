using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 추상 클래스와 프로퍼티 */
namespace AbstractClass2
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate { get; set; }  // 추상 프로퍼티
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new MyProduct() { ProductDate = new DateTime(2019, 9, 18) };
            Console.WriteLine("Product: {0}, ProductDate: {1}", p1.SerialID, p1.ProductDate);

            Product p2 = new MyProduct();
            p2.ProductDate = new DateTime(2019, 9, 19);
            Console.WriteLine($"Product: {p2.SerialID}, ProductDate: {p2.ProductDate}");
        }
    }
}
