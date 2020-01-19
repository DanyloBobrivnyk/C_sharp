using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Sharp_Project.Models;
namespace Sharp_Project.Interfaces
{
    public interface IWeatherForecast
    {
         Image GetIcon();
         string GetForecastInfo();
    }
}
