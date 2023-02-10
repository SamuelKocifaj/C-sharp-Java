
while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var name = values[0];
                    var nationality = values[1];
                    var team = values[2];
                    var age = int.Parse(values[3]);
                    var points = int.Parse(values[4]);
                    var dNF = int.Parse(values[5]);
                    var wins = int.Parse(values[6]);
                    var podiums = int.Parse(values[7]);
                    var fastestLaps = int.Parse(values[8]);
                    var driverOfTheDay = int.Parse(values[9]);
                    var mostOvertakes = int.Parse(values[10]);
                    var poles = int.Parse(values[11]);
                    var lapsLed = int.Parse(values[12]);

                    Drivers.Add(new F1Driver(name, nationality, team, age, points, dNF, wins, podiums, fastestLaps, driverOfTheDay, poles, lapsLed));
                }
                Drivers.Add(new F1Driver());
