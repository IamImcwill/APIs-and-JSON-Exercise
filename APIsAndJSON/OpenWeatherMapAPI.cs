using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void RealTimeWeatherByCity() 
        {
            string apiKey = "d388ab803b1669b457b23a02eede482d";

            HttpClient client = new HttpClient();

            string cityName = "Atlanta";

            string weatherEndpoint = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";

            string weatherResponse = client.GetStringAsync(weatherEndpoint).Result;

            JObject weatherObject = JObject.Parse(weatherResponse);

            Console.WriteLine(weatherObject);
        }

    }
}
