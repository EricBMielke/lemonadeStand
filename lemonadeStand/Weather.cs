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

        public static int createTemperature()
        {
            Random rnd = new Random();
            int temperature = rnd.Next(50, 100);
            Console.WriteLine("The weather today is : " + temperature);
            return temperature;
        }
        public static string createWeather() {
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
        public static string createForecast()
        {
            createWeather();
            return "foo";
        }
    }
}
