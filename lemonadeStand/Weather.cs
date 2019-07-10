using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Weather
    {
        static Random rng;
        static Weather()
        {
            rng = new Random();
        }

        public static int CreateTemperature(int dayCount, int temperatureTomorrow)
        {
            int temperature;
            if (dayCount == 0)
           
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
        public static int CreateForecast()
        {
            int temperatureTomorrow = rng.Next(50, 100);
            Console.WriteLine("The weather tomorrow is : " + temperatureTomorrow);
            return temperatureTomorrow;
        }

        public static string CreateWeather() {
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
