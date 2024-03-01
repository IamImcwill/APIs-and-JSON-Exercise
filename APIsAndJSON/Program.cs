using KanyeAndRon;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //QuoteGenerator.KanyeQuote();

            //QuoteGenerator.RonQuote();
            
            RonVSKanyeAPI.Convo();

            OpenWeatherMapAPI.RealTimeWeatherByCity();
        }
    }
}
