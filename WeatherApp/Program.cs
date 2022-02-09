using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string APIKey = JObject.Parse(File.ReadAllText("appsettings.json")).GetValue("DefaultKey").ToString();

            Console.WriteLine("Welcome to Carter Weather.\n");
            Console.WriteLine("Please enter your ZipCode:\n");
            var zip = Console.ReadLine();

            string apiCall = $"http://api.openweathermap.org/data/2.5/weather?zip={zip},us&units=imperial&appid={APIKey}";

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} in your zipcode of: {zip}");
        }
    }
}
