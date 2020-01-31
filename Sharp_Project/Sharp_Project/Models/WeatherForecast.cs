using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sharp_Project.Interfaces;
using System.Drawing;
using System.Net;
using System.IO;

namespace Sharp_Project.Models
{
    class WeatherForecast : IWeatherForecast
    {
        public WeatherForecast()
        { }
        public WeatherForecast(string name)
        {
            this.Name = name;
        }

        [JsonProperty("id")]
        public long Id { get; set; }
       
        [JsonProperty("name")]
        public string Name { get; set; }
        public WeatherInform[] Weather { get; set; }
        public MainInform Main { get; set; }


        public Image GetIcon()
        {
            string url = "http://openweathermap.org/img/wn/" + Weather[0].Icon + "@2x.png";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            WebResponse hhtpWebResponce = httpWebRequest.GetResponse();

            Image webImage = Image.FromStream(hhtpWebResponce.GetResponseStream());
            return webImage;
        }
        public virtual string GetForecastInfo()
        {
            var data = new StringBuilder();
            
            data.AppendLine($"Temp in {Name} : {Main.Temp},");
            data.AppendLine($"{Name} city id: {Id},");
            data.AppendLine($"Temp in C* feels_like : {Main.FeelsLike},");
            data.AppendLine($"Min Temp: {Main.TempMin},");
            data.AppendLine($"Max Temp: {Main.TempMax},");
            data.AppendLine($"Description :{Weather[0].Description}");

            return data.ToString();         
        }
    }
}
