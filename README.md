
public void LoadCsv(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            // Skip the first line
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                var name = values[0];
                var points = int.Parse(values[1]);
                var races = int.Parse(values[2]);

                Drivers.Add(new F1Driver(name, points, races));
            }
        }
