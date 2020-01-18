using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Sharp_Project.Models;
using Sharp_Project.Api;
using RestEase;

namespace Sharp_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Ui Event Handlers
        private void btnWthr_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(WeatherForecast("Mikołajów"));
            //var weather = Get("poznan");
            //MessageBox.Show(weather.ToString());

            /* WebRequest request = HttpWebRequest.Create("http://api.openweathermap.org/data/2.5/weather" + tbxUrl.Text+"8107b0082ca85449cf63e8f44eda0803");
             WebResponse response = request.GetResponse();
             StreamReader reader = new StreamReader(response.GetResponseStream());

             string Forecast_JSON = reader.ReadToEnd();

             var myForecast = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(Forecast_JSON);
             MessageBox.Show(myForecast.main.temp.ToString());*/
        }

        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtboxResponce.Text = txtboxResponce.Text + strDebugText + Environment.NewLine;
                txtboxResponce.SelectionStart = txtboxResponce.TextLength;
                txtboxResponce.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        private static string WeatherForecast(string city)
        {
            string responce;
            var key = "8107b0082ca85449cf63e8f44eda0803";
            var url = "http://api.openweathermap.org/data/2.5/weather?q="+city+"&units=metric&appid="+key;
            //var client = RestClient.For<IWeatherClient>(url);
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responce = streamReader.ReadToEnd(); 
            }
            
            WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(responce);
           
                return weatherForecast.ToString();
        }
           
    }
}
