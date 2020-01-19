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
using Sharp_Project.Interfaces;

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
            txtboxResponce.Text = "";
            string city = tbxCityName.Text;
            if(!string.IsNullOrWhiteSpace(city) && city[city.Length-1].ToString() != " ")
            {
                string cityForecastResponce = GetWeatherForecast(city);
                DebugOutput(cityForecastResponce);
                this.ActiveControl = tbxCityName;
            }
            else
            {
                MessageBox.Show("Write the correct city name to search...");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            this.ActiveControl = tbxCityName;//this code focuse your input on textbox           
        }
        private void tbxCityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                    btnWthr_MouseClick(this, null);
            }
        }

        #endregion

        private void DebugOutput(string strDebugText)
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
        private string GetWeatherForecast(string city)
        {
            string responce;
            const string  key = "8107b0082ca85449cf63e8f44eda0803";
            var url = "http://api.openweathermap.org/data/2.5/weather?q="+city+"&units=metric&appid="+key;

            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    responce = streamReader.ReadToEnd();
                    streamReader.Close();
                }

                IWeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(responce);


                pnlWeather.BackgroundImage = weatherForecast.GetIcon();

                return weatherForecast.GetForecastInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.");
                return ex + "\n\tMight be there is a problem with a city name...\n";
            }

        }
    }
}
