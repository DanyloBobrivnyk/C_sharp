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
            string city = tbxCityName.Text;
            string cityForecastResponce = GetWeatherForecast(city);
            debugOutput(cityForecastResponce);
            //MessageBox.Show(cityForecastResponce);
            //txtboxResponce.Text = cityForecastResponce.Replace("\n", Environment.NewLine);//it work's                       
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbxCityName;//this code focuse your input on textbox
            
        }
        private void tbxCityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(!string.IsNullOrWhiteSpace(tbxCityName.Text))
                {
                    btnWthr_MouseClick(this, null);
                }
                else
                {
                    MessageBox.Show("Write the city name to search...");
                }
            }
        }

        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                strDebugText = strDebugText.Replace("\n", Environment.NewLine);
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);//write the text and after that goes to the second line
                txtboxResponce.Text = txtboxResponce.Text + strDebugText + Environment.NewLine;//than add to the textbox your data
                txtboxResponce.SelectionStart = txtboxResponce.TextLength;//focus at the end of the text
                txtboxResponce.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        private static string GetWeatherForecast(string city)
        {
            string responce;
            const string  key = "8107b0082ca85449cf63e8f44eda0803";
            var url = "http://api.openweathermap.org/data/2.5/weather?q="+city+"&units=metric&appid="+key;

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
