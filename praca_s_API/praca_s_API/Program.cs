// See https://aka.ms/new-console-template for more informationthe wooden thing children count on
using praca_s_API;
using System.Text.Json;


string city = "Zilina";
string key1 = "f47f0a71b85c9bdcbfafab8941919564";
string url = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&appid={key1}";


using (HttpClient client = new HttpClient())
{
    HttpResponseMessage response = await client.GetAsync(url);
    if(response.IsSuccessStatusCode)
    {
        string json = await response.Content.ReadAsStringAsync();
        Forecast vypis = JsonSerializer.Deserialize<Forecast>(json);
        Console.WriteLine(json);
    }
    
}

