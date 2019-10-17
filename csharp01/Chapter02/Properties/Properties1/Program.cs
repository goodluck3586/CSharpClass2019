using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Getter, Setter와 Properties 비교 */
namespace Properties1
{
    class Persion_GetSet
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }
    }
    class Persion_Properties
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }  // value: 암묵적 매개변수
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persion_GetSet p1 = new Persion_GetSet();
            p1.SetName("장만월");
            Console.WriteLine(p1.GetName());

            Persion_Properties p2 = new Persion_Properties();
            p2.Name = "아이유";
            Console.WriteLine(p2.Name);

            int[] nums = new int[5];
            Console.WriteLine(nums.Length); 
        }
    }
}
