using sach;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


string answer;
do
{
    // Create ChessDotComApi instance
    var api = new ChessApi();
    // Get player information
    Console.Write("Enter chess.com username: ");
    string username = Console.ReadLine();
    Player player = await api.GetPlayer(username);

    // Get stats information
    Console.Write("Enter game mode (rapid/blitz/bullet): ");
    string gameMode = Console.ReadLine();
    Stats stats = await api.GetStats(username, gameMode);

    // Print player and stats information in table format
    var rows = new List<string[]>
        {
            new string[] { "Player Name:", player.Name },
            new string[] { "Location:", player.Location },
            new string[] { "League:", player.League },
            new string[] { "Status:", player.Status },
            new string[] { "Rating:", stats.Rating.ToString() },
            new string[] { "Best Rating:", stats.BestRating.ToString() },
            new string[] { "Wins:", stats.Wins.ToString() },
            new string[] { "Losses:", stats.Losses.ToString() },
            new string[] { "Draws:", stats.Draws.ToString() }
        };

    var tablePrinter = new Tabulka();
    tablePrinter.PrintTable(rows);

    Console.WriteLine("Do you want to check another username? (Y/N)");
     answer = Console.ReadLine().ToLower();
    

} while (answer == "y");

