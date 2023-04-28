using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Write("Enter Chess.com username: ");
            string username = Console.ReadLine();

            string statsApiUrl = $"https://api.chess.com/pub/player/{username}/stats";
            string playerApiUrl = $"https://api.chess.com/pub/player/{username}";

            using (var httpClient = new HttpClient())
            {
                // Fetch player information
                HttpResponseMessage playerResponse = await httpClient.GetAsync(playerApiUrl);
                playerResponse.EnsureSuccessStatusCode();

                string playerResponseBody = await playerResponse.Content.ReadAsStringAsync();
                dynamic playerResult = JsonConvert.DeserializeObject(playerResponseBody);

                // Fetch player stats
                HttpResponseMessage statsResponse = await httpClient.GetAsync(statsApiUrl);
                statsResponse.EnsureSuccessStatusCode();

                string statsResponseBody = await statsResponse.Content.ReadAsStringAsync();
                dynamic statsResult = JsonConvert.DeserializeObject(statsResponseBody);

                if (statsResult != null)
                {
                    List<string[]> tableRows = new List<string[]>();

                    // Player information
                    string[] playerRow = {
                    "Player",
                    playerResult?.name != null ? $"Name: {playerResult.name}" : "Name: N/A",
                    playerResult?.location != null ? $"Location: {playerResult.location}" : "Location: N/A",
                    playerResult?.last_online != null ? $"Last Online: {playerResult.last_online}" : "Last Online: N/A",
                    playerResult?.league != null ? $"League: {playerResult.league}" : "League: N/A",
                    playerResult?.status != null ? $"Status: {playerResult.status}" : "Status: N/A"
                };
                    tableRows.Add(playerRow);

                    // Rapid stats
                    string[] rapidRow = {
                    "Rapid",
                    statsResult?.chess_rapid?.last?.rating != null ? $"Rating: {statsResult.chess_rapid.last.rating}" : "Rating: N/A",
                    statsResult?.chess_rapid?.best?.rating != null ? $"Best Rating: {statsResult.chess_rapid.best.rating}" : "Best Rating: N/A",
                    statsResult?.chess_rapid?.record?.win != null ? $"Wins: {statsResult.chess_rapid.record.win}" : "Wins: N/A",
                    statsResult?.chess_rapid?.record?.loss != null ? $"Losses: {statsResult.chess_rapid.record.loss}" : "Losses: N/A",
                    statsResult?.chess_rapid?.record?.draw != null ? $"Draws: {statsResult.chess_rapid.record.draw}" : "Draws: N/A"
                };
                    tableRows.Add(rapidRow);

                    // Blitz stats
                    string[] blitzRow = {
                    "Blitz",
                    statsResult?.chess_blitz?.last?.rating != null ? $"Rating: {statsResult.chess_blitz.last.rating}" : "Rating: N/A",
                    statsResult?.chess_blitz?.best?.rating != null ? $"Best Rating: {statsResult.chess_blitz.best.rating}" : "Best Rating: N/A",
                    statsResult?.chess_blitz?.record?.win != null ? $"Wins: {statsResult.chess_blitz.record.win}" : "Wins: N/A",
                    };
                    tableRows.Add(rapidRow);

                    // Bullet stats
                    string[] bulletRow = {
                "Bullet",
                statsResult?.chess_bullet?.last?.rating != null ? $"Rating: {statsResult.chess_bullet.last.rating}" : "Rating: N/A",
                statsResult?.chess_bullet?.best?.rating != null ? $"Best Rating: {statsResult.chess_bullet.best.rating}" : "Best Rating: N/A",
                statsResult?.chess_bullet?.record?.win != null ? $"Wins: {statsResult.chess_bullet.record.win}" : "Wins: N/A",
                statsResult?.chess_bullet?.record?.loss != null ? $"Losses: {statsResult.chess_bullet.record.loss}" : "Losses: N/A",
                statsResult?.chess_bullet?.record?.draw != null ? $"Draws: {statsResult.chess_bullet.record.draw}" : "Draws: N/A"
            };
                    tableRows.Add(bulletRow);

                    // Print table
                    Console.WriteLine();
                    Console.WriteLine($"Stats for {username}:");
                    Console.WriteLine("----------------------------------");
                    foreach (var row in tableRows)
                    {
                        if (row.Length >= 6)
                        {
                            Console.WriteLine($"{row[0],-10} {row[1],-25} {row[2],-25} {row[3],-25} {row[4],-25} {row[5],-25}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"No stats found for {username}");
                }
            }
        }
    }
}



