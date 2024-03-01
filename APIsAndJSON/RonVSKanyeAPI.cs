using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        private static int quote;

        public static void Ron() 
        { 
        
            HttpClient client = new HttpClient();

            string ronEndpoint = "http://ron-swanson-quotes.herokuapp.com/v2/quotes";

            string ronResponse = client.GetStringAsync(ronEndpoint).Result;

            var ronObject = JArray.Parse(ronResponse);

            Console.WriteLine($"Ron: {ronObject[0]}");
        }

        public static void Kanye()
        { 
            HttpClient client = new HttpClient();

            string kanyeEndpoint = "http://api.kanye.rest/";
            
            string kanyeReponse = client.GetStringAsync(kanyeEndpoint).Result;
            
            JObject kanyeObject = JObject.Parse(kanyeReponse);
            
            Console.WriteLine($"Kanye: {kanyeObject ["quote"]}");
        }

        public static void Convo()
        {
            for (int i = 0;  i < 5; i++) 
            {
                Ron();
                Kanye();
                Console.WriteLine();

            }
        }
    }
}