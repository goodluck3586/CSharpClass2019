using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_AccessModifier02
{
    /* 온수기: 온도 설정 가능, 온도 조회 가능 */
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temp)
        {
            if(temp <-5 || temp > 42)
            {
                throw new Exception("Out of temperature range");  // 에러 발생
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
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-20);  // error
                heater.TurnOnWater();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            heater.SetTemperature(10);
            heater.TurnOnWater();

        }
    }
}
