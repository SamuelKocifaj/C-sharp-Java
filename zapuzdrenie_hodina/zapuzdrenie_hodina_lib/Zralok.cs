using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class Zralok:WarmBlooded
    {
        public bool Dangerous;
        public int PocetZubov;
        public Zralok(string name, double weight, string owner, Tuple<double, double, double> terrariumSize, bool dangerous, int pocetzubov) : base(name, weight, owner, terrariumSize)
        {
            this.Dangerous = dangerous;
            this.PocetZubov = pocetzubov;
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Zralek {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"PocetZubov {PocetZubov}");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine($"Terrarium size is {calcTerrariumSize()}cm3");
            if (Dangerous)
                sb.AppendLine($"Je nebezpecny");
            else
                sb.AppendLine($"Nie je nebezpecny");
            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }






    }
}
