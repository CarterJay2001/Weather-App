using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public class WeatherMap
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            return double.Parse(JObject.Parse(client.GetStringAsync(apiCall).Result)["main"]["temp"].ToString());

        }
    }
}
