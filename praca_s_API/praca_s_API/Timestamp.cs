using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace praca_s_API
{
    public class Timestamp
    {
        [JsonPropertyName("dt_txt")]public string Time { get; set; }
        [JsonPropertyName("main")]public Info Details { get; set; }
        [JsonPropertyName("weather")]public List<Weather> Sky { get; set; }
        

        public Timestamp()
        {
            Sky = new List<Weather>();
        }
    }
}
