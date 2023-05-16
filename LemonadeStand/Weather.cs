using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {   
        Random random;
        public int Temperature;
        public int TodayTemperature;
        private string weatherConditions;
        public string predictedForecast;
        public Weather()
        {
            random = new Random();
            TodayTemperature = 0;
            predictedForecast = "";
        }
        public void GetWeatherTemperatureToday()
        {
            Temperature = random.Next(50, 90);
            TodayTemperature = Temperature;
        }
        public void GetWeatherForecastToday()
        {
            List<string> TypesOfWeather = new List<string> { "Rainy", "Sunny", "Partly Cloudy" };
            weatherConditions = TypesOfWeather[random.Next(0, 2)];
            predictedForecast = weatherConditions;
        }
    }
}




