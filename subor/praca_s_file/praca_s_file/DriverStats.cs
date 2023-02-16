using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praca_s_file
{
    public class DriverStats
    {
        public List<F1Driver> Drivers { get; set; }

        public DriverStats()
        {
            Drivers = new List<F1Driver>();
        }


        public void LoadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {

                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var name = values[0];
                    var nationality = values[1];
                    var team = values[2];
                    var age = int.Parse(values[3]);
                    var points = int.Parse(values[4]);
                    var dnf = int.Parse(values[5]);
                    var wins = int.Parse(values[6]);
                    var podiums = int.Parse(values[7]);
                    var fastestLaps = int.Parse(values[8]);
                    var driverOfTheDay = int.Parse(values[9]);
                    var mostOvertakes = int.Parse(values[10]);
                    var poles = int.Parse(values[11]);
                    var lapsLed = int.Parse(values[12]);

                    var driver = new F1Driver(name, nationality, team, age, points, dnf, wins, podiums, fastestLaps, driverOfTheDay, mostOvertakes, poles, lapsLed);

                    Drivers.Add(driver);
                }
            }
        }

        public string MostScoredPoints()
        {
            int maxPoints = 0;
            string driverName = "";
            foreach (F1Driver driver in Drivers)
            {
                if (driver.Points > maxPoints)
                {
                    maxPoints = driver.Points;
                    driverName = driver.Name;
                }
            }
            return $"{driverName} ({maxPoints} points)";
        }

        public string MostPoles()
        {
            int maxPoles = 0;
            string driverName = "";
            foreach (F1Driver driver in Drivers)
            {
                if (driver.Poles > maxPoles)
                {
                    maxPoles = driver.Poles;
                    driverName = driver.Name;
                }
            }
            return $"{driverName} ({maxPoles} poles)";
        }

        public string MostLapsLed()
        {
            F1Driver mostLapsLedDriver = Drivers.OrderByDescending(d => d.LapsLed).FirstOrDefault();
            return $"{mostLapsLedDriver.Name} ({mostLapsLedDriver.LapsLed} laps led)";
        }

        public void SaveTxt(string filePath)
        {
            string path = @"..\\..\\..\\Resources\\f1_drivers_points.csv";
             using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            string path1 = @"..\\..\\..\\Resources\\f1_drivers_points.csv";
            using (StreamWriter sw = new StreamWriter(path1))
            {
                Console.WriteLine(MostScoredPoints);
                Console.WriteLine(MostPoles);
                Console.WriteLine(MostLapsLed);
                sw.WriteLine(MostScoredPoints);
                sw.WriteLine(MostPoles);
                sw.WriteLine(MostLapsLed);
            }
        }

    }
}

