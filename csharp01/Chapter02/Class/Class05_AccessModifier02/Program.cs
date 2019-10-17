using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_AccessModifier02
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temp)
        {
            if (temp < -5 || temp > 100)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temp;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            WaterHeater heater = new WaterHeater();
            try
            {
                heater.SetTemperature(200);
                heater.TurnOnWater();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
