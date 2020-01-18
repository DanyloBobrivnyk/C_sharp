using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sharp_Project.Models
{
    public class WeatherForecast 
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public MainInform Main { get; set; }

        public override string ToString()
        {
            return $"Temp in {Name} : {Main.Temp}\n" +
                $"{Name} city id: {Id}\n" +
                $"Temp in C* feels_like : {Main.FeelsLike}\n" +
                $"Min Temp: {Main.TempMin}\n" +
                $"Max Temp: {Main.TempMax}.\n";
        }
    }
}
