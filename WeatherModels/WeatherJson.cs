using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherModels
{
    [Serializable]
    public class WeatherJson
    {

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

        public class Main
        {

            [JsonProperty("temp")]
            public double temp { get; set; }

            [JsonProperty("pressure")]
            public double pressure { get; set; }

            [JsonProperty("humidity")]
            public double humidity { get; set; }
        }

        public class Wind
        {

            [JsonProperty("speed")]
            public double speed { get; set; }

            [JsonProperty("deg")]
            public double deg { get; set; }
        }

        public class Clouds
        {

            [JsonProperty("all")]
            public int all { get; set; }
        }

        public class Sys
        {

            [JsonProperty("type")]
            public int type { get; set; }

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("message")]
            public double message { get; set; }

            [JsonProperty("country")]
            public string country { get; set; }

            [JsonProperty("sunrise")]
            public int sunrise { get; set; }

            [JsonProperty("sunset")]
            public int sunset { get; set; }
        }

        public class WeatherRoot
        {
            [JsonProperty("weather")]
            public IList<Weather> weather { get; set; }

            [JsonProperty("basic")]
            public string basic { get; set; }

            [JsonProperty("main")]
            public Main main { get; set; }

            [JsonProperty("visibility")]
            public int visibility { get; set; }

            [JsonProperty("wind")]
            public Wind wind { get; set; }

            [JsonProperty("clouds")]
            public Clouds clouds { get; set; }

            [JsonProperty("dt")]
            public int dt { get; set; }

            [JsonProperty("sys")]
            public Sys sys { get; set; }

            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("cod")]
            public int cod { get; set; }
        }
    }
}
