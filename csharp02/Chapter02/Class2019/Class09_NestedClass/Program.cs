using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class09_NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }
            return "해당 item이 없습니다.";
        }

        private class ItemValue
        {
            string item;
            string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if(config.listConfig[i].item == item)
                    {
                        config.listConfig[i].value = value;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem()
            {
                return item;
            }
            public string GetValue()
            {
                return value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version"));  // "V 5.0"
            Console.WriteLine(config.GetConfig("Price"));  // 없다.

            config.SetConfig("Version", "V 7.0");
            Console.WriteLine(config.GetConfig("Version"));  // "V 7.0"
        }
    }
}
