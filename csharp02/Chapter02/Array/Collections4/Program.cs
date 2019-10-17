using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hashtable, Dictionary */
/* (key, value)의 쌍으로 이루어진 데이터 저장 */
namespace Collections4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region System.Collections.Hashtable
            Hashtable ht = new Hashtable()
            {
                [1] = "하나",
                [2] = "둘",
                [3] = "셋"
            };
            ht.Add("Name", "아이유");
            ht["Age"] = 26;
            PrintHashtable(ht);

            if (ht.ContainsKey("Name"))
                ht["Name"] = "장만월";
            else
                ht.Add("Name", "장만월");
            PrintHashtable(ht);

            if (ht.ContainsValue("넷"))
                Console.WriteLine("이미 값이 존재함.");
            else
                ht[4] = "넷";
            PrintHashtable(ht);
            #endregion

            #region System.Collections.Generic.Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>
            {
                [1] = "하나",
                [2] = "둘"
            };
            dic[3] = "셋";
            dic.Add(4, "넷");
            PrintDictionary(dic);

            Dictionary<string, int> dic2 = new Dictionary<string, int>
            {
                ["하나"] = 1,
                ["둘"] = 2
            };
            PrintDictionary2<string, int>(dic2);
            PrintDictionary2<int, string>(dic);
            #endregion
        }

        private static void PrintDictionary2<K, V>(Dictionary<K, V> dic)
        {
            foreach (var item in dic.Keys)
                Console.Write($"{dic[item]} ");
            Console.WriteLine('\n');
        }

        private static void PrintDictionary(Dictionary<int, string> dic)
        {
            foreach (var item in dic.Keys)
                Console.Write($"{dic[item]} ");
            Console.WriteLine('\n');
        }

        private static void PrintHashtable(Hashtable ht)
        {
            foreach (var item in ht.Keys)
                Console.Write($"{ht[item]} ");
            Console.WriteLine('\n');
        }
    }
}
