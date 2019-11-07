using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm10_ListView
{
    class Person
    {
        public static int id;

        public Person()
        {
            id++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MajorWork { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"Name: {Name}\n" +
                $"MajorWork: {MajorWork}";
        }
    }
}
