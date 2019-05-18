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
    /// Логика взаимодействия для DaysForm.xaml
    /// </summary>
    public partial class DaysForm : Window
    {
        const string APPID = "0950a94b6ba254384678c1be23bf9f03";
        public DaysForm(string city)
        {
            InitializeComponent();
            GetForeCast(city);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        void GetForeCast(string city)
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&APPID={1}&units=metric&cnt=6", city, APPID); 
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);

                var objects = JsonConvert.DeserializeObject<WeatherDays.ForeCast>(json);

                WeatherDays.ForeCast days = objects;

                string getImage2 = days.list[1].weather[0].icon;
                image2.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + getImage2 + ".png"));
                day_of_week2.Text = string.Format("{0}", GetDate(days.list[1].dt + 86400).DayOfWeek);
                text_date2.Text = string.Format("{0}", GetDate(days.list[1].dt+ 86400));
                text_temperature2.Text = string.Format("{0}", days.list[1].main.temp + " C");
                text_humidity2.Text = string.Format("{0}", days.list[1].main.humidity + " %");
                text_wind2.Text = string.Format("{0}", days.list[1].wind.speed + " km/h");

                string getImage3 = days.list[2].weather[0].icon;
                image3.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + getImage3 + ".png"));
                day_of_week3.Text = string.Format("{0}", GetDate(days.list[2].dt + 172800).DayOfWeek);
                text_date3.Text = string.Format("{0}", GetDate(days.list[2].dt + 172800));
                text_temperature3.Text = string.Format("{0}", days.list[2].main.temp + " C");
                text_humidity3.Text = string.Format("{0}", days.list[2].main.humidity + " %");
                text_wind3.Text = string.Format("{0}", days.list[2].wind.speed + " km/h");

                string getImage4 = days.list[3].weather[0].icon;
                image4.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + getImage4 + ".png"));
                text_date4.Text = string.Format("{0}", GetDate(days.list[3].dt+ 259200));
                day_of_week4.Text = string.Format("{0}", GetDate(days.list[3].dt + 259200).DayOfWeek);
                text_temperature4.Text = string.Format("{0}", days.list[3].main.temp + " C");
                text_humidity4.Text = string.Format("{0}", days.list[3].main.humidity + " %");
                text_wind4.Text = string.Format("{0}", days.list[3].wind.speed + " km/h");

                string getImage5 = days.list[4].weather[0].icon;
                image5.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + getImage5 + ".png"));
                text_date5.Text = string.Format("{0}", GetDate(days.list[4].dt+ 345600));
                day_of_week5.Text = string.Format("{0}", GetDate(days.list[4].dt + 345600).DayOfWeek);
                text_temperature5.Text = string.Format("{0}", days.list[4].main.temp + " C");
                text_humidity5.Text = string.Format("{0}", days.list[4].main.humidity + " %");
                text_wind5.Text = string.Format("{0}", days.list[4].wind.speed + " km/h");

                string getImage6 = days.list[5].weather[0].icon;
                image6.Source = new BitmapImage(new Uri(@"https://openweathermap.org/img/w/" + getImage6 + ".png"));
                text_date6.Text = string.Format("{0}", GetDate(days.list[5].dt+ 432000));
                day_of_week6.Text = string.Format("{0}", GetDate(days.list[5].dt + 432000).DayOfWeek);
                text_temperature6.Text = string.Format("{0}", days.list[5].main.temp + " C");
                text_humidity6.Text = string.Format("{0}", days.list[5].main.humidity + " %");
                text_wind6.Text = string.Format("{0}", days.list[5].wind.speed + " km/h");
            }
        }
        DateTime GetDate(double milliseconds)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milliseconds).ToLocalTime();

            return day;
        }
    }
}
