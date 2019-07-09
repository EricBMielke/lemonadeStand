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

        public static int createWeather()
        {
            List<string> weatherList = new List<string>();
            weatherList.Add("Sunny");
            weatherList.Add("Cloudy");
            weatherList.Add("Rainy");
            weatherList.Add("Hazy");
            Random rnd = new Random();
            int weatherNumber = rnd.Next(3);
            string actualWeather = weatherList[weatherNumber];
            int temperature = rnd.Next(50, 100);
            Console.WriteLine("The weather today is : " + temperature + " & " + actualWeather);
            return temperature;
        }
    }
}
