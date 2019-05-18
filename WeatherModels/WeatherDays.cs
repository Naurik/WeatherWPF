using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherModels
{
    [Serializable]
    public class WeatherDays
    {
        public class Main
        {

            [JsonProperty("temp")]
            public double temp { get; set; }
            
            [JsonProperty("pressure")]
            public double pressure { get; set; }
            
            [JsonProperty("humidity")]
            public int humidity { get; set; }
        }

        public class Weather
        {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("main")]
            public string main { get; set; }

            [JsonProperty("description")]
            public string description { get; set; }

            [JsonProperty("icon")]
            public string icon { get; set; }
        }

        public class Clouds
        {

            [JsonProperty("all")]
            public int all { get; set; }
        }

        public class Wind
        {

            [JsonProperty("speed")]
            public double speed { get; set; }

            [JsonProperty("deg")]
            public double deg { get; set; }
        }

        public class Sys
        {

            [JsonProperty("pod")]
            public string pod { get; set; }
        }

        public class List
        {

            [JsonProperty("dt")]
            public int dt { get; set; }

            [JsonProperty("main")]
            public Main main { get; set; }

            [JsonProperty("weather")]
            public IList<Weather> weather { get; set; }

            [JsonProperty("clouds")]
            public Clouds clouds { get; set; }

            [JsonProperty("wind")]
            public Wind wind { get; set; }

            [JsonProperty("sys")]
            public Sys sys { get; set; }

            [JsonProperty("dt_txt")]
            public string dt_txt { get; set; }
        }
        
        public class City
        {

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("country")]
            public string country { get; set; }

            [JsonProperty("population")]
            public int population { get; set; }
        }

        public class ForeCast
        {

            [JsonProperty("cod")]
            public string cod { get; set; }

            [JsonProperty("message")]
            public double message { get; set; }

            [JsonProperty("cnt")]
            public int cnt { get; set; }

            [JsonProperty("list")]
            public IList<List> list { get; set; }

            [JsonProperty("city")]
            public City city { get; set; }
        }
    }
}
