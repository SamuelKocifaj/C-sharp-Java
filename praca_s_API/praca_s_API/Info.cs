using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace praca_s_API
{
    public class Info
    {
        [JsonPropertyName("temp")] public double Temperature { get; set; }
        [JsonPropertyName("pressure")] public double Pressure { get; set; }
        [JsonPropertyName("humidity")] public double Humidity { get; set; }
    }
}
