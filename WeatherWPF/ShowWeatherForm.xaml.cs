using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WeatherModels;

namespace WeatherWPF
{
    /// <summary>
    /// Логика взаимодействия для ShowWeatherForm.xaml
    /// </summary>
    public partial class ShowWeatherForm : Window
    {
        const string APPID = "0950a94b6ba254384678c1be23bf9f03";
        public ShowWeatherForm(string cityName)
        {
            InitializeComponent();
            GetWeather(cityName);
        }

        void GetWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&units=metric&cnt=6", city, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherJson.WeatherRoot>(json);
                WeatherJson.WeatherRoot output = result;

                string getImage1 = output.weather[0].icon;

                image1.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + getImage1 + ".png"));
                day_of_weeks1.Text = string.Format("{0}", GetDate(output.dt).DayOfWeek);
                text_date1.Text = string.Format("{0}", GetDate(output.dt)); 
                text_cityName.Text = string.Format("{0}", output.name);
                text_country.Text = string.Format("{0}", output.sys.country);
                text_temperature1.Text = string.Format("{0}", output.main.temp + " C");
                text_humidity1.Text = string.Format("{0}", output.main.humidity + " %");
                text_wind1.Text = string.Format("{0}", output.wind.speed + " km/h");
                
            }
        }

        DateTime GetDate(double milliseconds)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milliseconds).ToLocalTime();

            return day;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DaysForm days = new DaysForm(text_cityName.Text);
            days.Show();
        }
    }
}
