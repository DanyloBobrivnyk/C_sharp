using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sharp_Project.Interfaces;

namespace Sharp_Project.Models
{
    class ExtendedWeatherForecast : WeatherForecast, IWeatherForecast
    {
       public WindInform Wind { get; set; }

       //public WeatherInform[] WeatherMain { get; set; }
       public SysInform Sys { get; set; }

        public override string GetForecastInfo()
        {
            string oldData = base.GetForecastInfo();

            var data = new StringBuilder();

            data.Append(oldData);
           // data.AppendLine($"Additional information: {Weather[0].Main}");
            
            data.AppendLine($"Pressure: {Main.Pressure} hPa");
            data.AppendLine($"Humidity: {Main.Humidity} %");
            data.AppendLine($"Wind speed: {Wind.Speed} meter/sec");
            data.AppendLine($"Country: {Sys.Country}");

            return data.ToString();
        }

    }
}
