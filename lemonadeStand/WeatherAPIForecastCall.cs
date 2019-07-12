using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class WeatherAPIForecastCall
    {
    }
    public class City
    {
        public int geoname_id { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string country { get; set; }
        public string iso2 { get; set; }
        public string type { get; set; }
        public int population { get; set; }
    }

    public class Temp
    {
        public double day { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double night { get; set; }
        public double eve { get; set; }
        public double morn { get; set; }
    }

    public class ForecastWeather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Temp temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public List<Weather> weather { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public int clouds { get; set; }
        public double snow { get; set; }
    }

    public class RootObject3
    {
        public string cod { get; set; }
        public int message { get; set; }
        public City city { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
    }
    public class OnlineForecast
    {

        private const string URL = "http://api.openweathermap.org/data/2.5/forecast";

        public async Task<double> fetchForecastOnline(string city, int dayCount)
        {
            double updatedOnlineForecast = 0;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            // List data response.
            HttpResponseMessage response = client.GetAsync("?q=" + city + "&APPID=f26747d8158f3b5f64a4586f6c4684b9").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic parsedBody = JsonConvert.DeserializeObject(responseBody);
                string realTimeForecast="0";
                try
                {
                    realTimeForecast = parsedBody.list[dayCount * 8].main.temp;
                }
                catch (Exception)
                {
                    realTimeForecast = "0";
                }
                WeatherStatus onlineForecast = new WeatherStatus();
                if (realTimeForecast != "0")
                {
                    updatedOnlineForecast = onlineForecast.RealTimeTempConvert(realTimeForecast);
                    return updatedOnlineForecast;
                }
                else
                {
                    updatedOnlineForecast = 0;
                    return updatedOnlineForecast;
                }
            }
            else
            {
                Console.WriteLine("We were unable to connect your city with our online database, but we have generated a temperature for you.");
                updatedOnlineForecast = 0;
                return updatedOnlineForecast;
            }
        }
    }
}
