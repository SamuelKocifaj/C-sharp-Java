using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace praca_s_file
{
    public class F1Driver
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Team { get; set; }
        public int Age { get; set; }
        public int Points { get; set; }
        public int DNF { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int FastestLaps { get; set; }
        public int DriverOfTheDay { get; set; }
        public int MostOvertakes { get; set; }
        public int Poles { get; set; }
        public int LapsLed { get; set; }

        public F1Driver(string name, string nationality, string team, int age, int points, int dnf, int wins, int podiums, int fastestLaps, int driverOfTheDay, int mostOvertakes, int poles, int lapsLed)
        {
            Name = name;
            Nationality = nationality;
            Team = team;
            Age = age;
            Points = points;
            DNF = dnf;
            Wins = wins;
            Podiums = podiums;
            FastestLaps = fastestLaps;
            DriverOfTheDay = driverOfTheDay;
            MostOvertakes = mostOvertakes;
            Poles = poles;
            LapsLed = lapsLed;
        }


    }
}
