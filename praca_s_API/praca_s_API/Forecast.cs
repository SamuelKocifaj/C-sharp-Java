using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace praca_s_API
{
    public class Forecast
    {
        [JsonPropertyName("list")] public List<Timestamp>CityForecast { get; set; }
        public Forecast()
        {
            CityForecast = new List<Timestamp>();
        }
        public override string ToString()
        {
            string output = " ";
            foreach(Timestamp nieco in CityForecast)
            {
                output+=nieco.ToString();
            }
            return output;
        }

    }
}
