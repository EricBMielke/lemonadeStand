using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class WeatherStatus
    {
        static Random rng;
        static WeatherStatus()
        {
            rng = new Random();
        }

        public double RealTimeTempConvert (string foundTemp)
        {
            double foundTempDouble = Double.Parse(foundTemp);
            double updatedTemp = Math.Round(((foundTempDouble - 273) * 1.8) + 32);
            return updatedTemp;
        }
        public int CreateTemperature(int dayCount, int temperatureTomorrow, double updatedOnlineTemp)
        {
            int temperature;
            if (dayCount == 0 && updatedOnlineTemp != 0)
            {
                int updatedOnlineTempInt = Convert.ToInt32(updatedOnlineTemp);
                temperature = updatedOnlineTempInt;
            }
            else if (dayCount == 0)
            {
                
                temperature = rng.Next(50, 100);
            }
            else
            {
                temperature = temperatureTomorrow;
            }
            Console.WriteLine("The weather today is : " + temperature);
            return temperature;
        }
        public int CreateForecast()
        {
            int temperatureTomorrow = rng.Next(50, 100);
            Console.WriteLine("The weather tomorrow is : " + temperatureTomorrow);
            return temperatureTomorrow;
        }

        public string CreateWeather() {
            List<string> weatherList = new List<string>();
            weatherList.Add("sunny");
            weatherList.Add("cloudy");
            weatherList.Add("rainy");
            weatherList.Add("hazy");
            
            int weatherNumber = rng.Next(3);
            string actualWeather = weatherList[weatherNumber];
            return actualWeather;
        }
    }
}
