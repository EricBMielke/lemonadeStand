using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Weather
    {
        public int temperature;
        public int weatherType;

        public static int CreateTemperature(int dayCount, int temperatureTomorrow)
        {
            int temperature;
            if (dayCount == 0)
           
            {
                Random rnd = new Random();
                temperature = rnd.Next(50, 100);
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
            Random rnd = new Random();
            int temperatureTomorrow = rnd.Next(50, 100);
            Console.WriteLine("The weather tomorrow is : " + temperatureTomorrow);
            return temperatureTomorrow;
        }

        public static string CreateWeather() {
            List<string> weatherList = new List<string>();
            weatherList.Add("sunny");
            weatherList.Add("cloudy");
            weatherList.Add("rainy");
            weatherList.Add("hazy");
            Random rnd = new Random();
            int weatherNumber = rnd.Next(3);
            string actualWeather = weatherList[weatherNumber];
            return actualWeather;
        }
    }
}
