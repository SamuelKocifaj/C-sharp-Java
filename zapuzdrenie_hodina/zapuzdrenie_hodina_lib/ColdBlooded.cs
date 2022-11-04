using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class ColdBlooded : Animal
    {
        public Tuple<double, double, double> TerrariumSize { get; set; }
        public ColdBlooded(string name, double weight, string owner, Tuple<double, double, double> terrariumSize) : base(name, weight, owner)
        {
            this.TerrariumSize = terrariumSize;
        }

        protected double calcTerrariumSize()
        {
            return this.TerrariumSize.Item1 * this.TerrariumSize.Item2 * this.TerrariumSize.Item3;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Cold-blooded animal {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine($"Terrarium size is {calcTerrariumSize()}m3");
            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }

    }
}
