using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        //Member Variables (Has A)
        public string condition;
        public int temeperature;
        private List<string> weatherConditions;
        public string predictedForecast;


        //Constructor
        public Weather()
        {
            this.condition = condition;
            this.temeperature = temeperature;
            weatherConditions = new List<string> { "Clear Skies", "Cloudy", "Rain" };
            predictedForecast = "";

        }


        //Member Methods (Can Do)
    }
}
