namespace sach
{
    public class Tabulka
    {
        public void PrintTable(List<string[]> rows)
        {
            // Find the maximum length of each column
            int[] columnWidths = new int[rows[0].Length];
            for (int i = 0; i < rows[0].Length; i++)
            {
                columnWidths[i] = rows.Max(row => row[i].Length);
            }

            // Print the table
            foreach (var row in rows)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    Console.Write(row[i].PadRight(columnWidths[i] + 2));
                }
                Console.WriteLine();
            }
        }
    }
}

