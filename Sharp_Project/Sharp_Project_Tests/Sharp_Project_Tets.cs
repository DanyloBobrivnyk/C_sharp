using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sharp_Project.Models;
using Xunit;

namespace Sharp_Project_Tests
{
    
    public class Sharp_Project_Tets
    {
        //private readonly WeatherForecast forecast;

        [Fact]
        public void GetWeatherForecast_Validation_Success()
        {
            var name = "London";
            long city_Id = 124214;
            double feels_like = 41.21;
            double temp = 40.21;
            double temp_min = 42.12;
            double temp_max = 51.21;
            string description = "la-la";
            var expectdValue = "Temp in London : 40.21," +
                "London city id: 124214,"+
                "Temp in C* feels_like : 41.21,"+
                "Min Temp: 42.12,"+
            "Max Temp: 51.21,"+
            "Description :la-la";

            var data = new StringBuilder();

            data.AppendLine($"Temp in {name} : {temp},");
            data.AppendLine($"{name} city id: {city_Id},");
            data.AppendLine($"Temp in C* feels_like : {feels_like},");
            data.AppendLine($"Min Temp: {temp_min},");
            data.AppendLine($"Max Temp: {temp_max},");
            data.AppendLine($"Description :{description}");

            data.Equals(expectdValue);
        }
    }
}
