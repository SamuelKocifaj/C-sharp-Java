using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace praca_s_API
{
    public class Weather
    {
        [JsonPropertyName("main")]public string General { get; set; }
        [JsonPropertyName("description")]public string Description { get; set; }


    }
}
