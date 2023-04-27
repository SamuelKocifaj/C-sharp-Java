using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Enter Chess.com username: ");
        string username = Console.ReadLine();

        string apiUrl = $"https://api.chess.com/pub/player/{username}/stats";

        using (var httpClient = new HttpClient())
        {
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic result = JsonConvert.DeserializeObject(responseBody);

            if (result != null)
            {
                List<string[]> tableRows = new List<string[]>();

                // Rapid
                string[] rapidRow = {
                    "Rapid",
                    $"Rating: {result.chess_rapid.last.rating}",
                    $"Best Rating: {result.chess_rapid.best.rating}",
                    $"Wins: {result.chess_rapid.record.win}",
                    $"Losses: {result.chess_rapid.record.loss}",
                    $"Draws: {result.chess_rapid.record.draw}"
                };
                tableRows.Add(rapidRow);

                // Blitz
                string[] blitzRow = {
                    "Blitz",
                    $"Rating: {result.chess_blitz.last.rating}",
                    $"Best Rating: {result.chess_blitz.best.rating}",
                    $"Wins: {result.chess_blitz.record.win}",
                    $"Losses: {result.chess_blitz.record.loss}",
                    $"Draws: {result.chess_blitz.record.draw}"
                };
                tableRows.Add(blitzRow);

                // Puzzle
                string[] puzzleRow = {
                    "Puzzle",
                    $"Highest: {result.tactics.highest.rating}",
                    $"Lowest: {result.tactics.lowest.rating}"
                };
                tableRows.Add(puzzleRow);

                // Calculate column widths based on longest values in each column
                int[] columnWidths = new int[tableRows[0].Length];
                for (int i = 0; i < tableRows.Count; i++)
                {
                    for (int j = 0; j < tableRows[i].Length; j++)
                    {
                        columnWidths[j] = Math.Max(columnWidths[j], tableRows[i][j].Length);
                    }
                }

                // Print table with adjusted column widths and semigraphic characters
                Console.WriteLine(new string('─', columnWidths.Sum() + 3 * columnWidths.Length + 1));
                foreach (string[] row in tableRows)
                {
                    Console.Write("│ ");
                    for (int i = 0; i < row.Length; i++)
                    {
                        Console.Write(row[i].PadRight(columnWidths[i] + 1));
                        Console.Write("│ ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(new string('─', columnWidths.Sum() + 3 * columnWidths.Length + 1));
                }
            }
            else
            {
                Console.WriteLine($"Error: No data found for {username}.");
            }
        }

        Console.ReadLine();
    }
}
