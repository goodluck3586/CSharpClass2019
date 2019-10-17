﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 인터페이스와 프로퍼티 */
namespace Interface2
{
    interface IProduct
    {
        string ProductName { get; set; }
        int Price { get; set; }
    }

    class Product : IProduct
    {
        private string productName;

        public string ProductName { get { return productName; } set { productName = value; } }
        public int Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IProduct p = new Product();
            p.ProductName = "노트북";
            p.Price = 1_500_000;

            Console.WriteLine($"{p.ProductName}: {p.Price}");
        }
    }
}
