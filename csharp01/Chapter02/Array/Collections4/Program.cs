using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hashtable, Dictionary */
/* (key, value) 쌍 형태의 데이터 저장 */
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
                ht.Add(4, "넷");
            #endregion

            #region System.Collections.Generic.Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                [1] = "하나",
                [2] = "둘"
            };
            dic[3] = "셋";
            dic.Add(4, "넷");
            PrintDictionary(dic);
            #endregion

            #region 추가 학습
            PrintDictionary2<int, string>(dic);

            Dictionary<string, string> dic2 = new Dictionary<string, string>()
            {
                ["one"] = "하나",
                ["two"] = "둘"
            };
            PrintDictionary2<string, string>(dic2);
            #endregion
        }

        private static void PrintDictionary(Dictionary<int, string> dic)
        {
            foreach (var key in dic.Keys)
                Console.Write($"{dic[key]} ");
            Console.WriteLine('\n');
        }

        #region 추가 학습
        private static void PrintDictionary2<K, V>(Dictionary<K,V> dic)
        {
            foreach (var key in dic.Keys)
                Console.Write($"{dic[key]} ");
            Console.WriteLine('\n');
        }
        #endregion

        private static void PrintHashtable(Hashtable ht)
        {
            foreach (var item in ht.Keys)
                Console.Write($"{ht[item]} ");
            Console.WriteLine('\n');
        }
    }
}
