using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lemonadeStand
{
    public class DataObject
    {
        public string Name { get; set; }
    }
    public class Program
    {
        private const string URL = "http://api.openweathermap.org/data/2.5/weather";
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Game game = new Game();
            Setup setup = new Setup();
            do
            {
                await game.RunGame();
            }
            while (!setup.AskToReplay());
        }
    }
}
