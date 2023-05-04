using Newtonsoft.Json;

namespace sach
{
    public class ChessApi
    {
        private readonly HttpClient _httpClient;

        public ChessApi()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Player> GetPlayer(string username)
        {
            string apiUrl = $"https://api.chess.com/pub/player/{username}";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic result = JsonConvert.DeserializeObject(responseBody);

            if (result != null)
            {
                return new Player
                {
                    Name = result.name ?? "N/A",
                    Location = result.location ?? "N/A",
                    League = result.league ?? "N/A",
                    Status = result.status ?? "N/A"
                };
            }
            else
            {
                return null;
            }
        }

        public async Task<Stats> GetStats(string username, string gameMode)
        {
            string apiUrl = $"https://api.chess.com/pub/player/{username}/stats";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic result = JsonConvert.DeserializeObject(responseBody);

            if (result != null)
            {
                dynamic gameModeStats = result[$"chess_{gameMode}"];

                return new Stats
                {
                    Rating = gameModeStats?.last?.rating ?? 0,
                    BestRating = gameModeStats?.best?.rating ?? 0,
                    Wins = gameModeStats?.record?.win ?? 0,
                    Losses = gameModeStats?.record?.loss ?? 0,
                    Draws = gameModeStats?.record?.draw ?? 0
                };
            }
            else
            {
                return null;
            }
        }
    }
}

