using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class Fish : ColdBlooded
    {
        private bool seawater;
        private bool predatory;

        public Fish(string name, double weight, string owner, Tuple<double, double, double> terrariumSize, bool seawater, bool predatory) : base(name, weight, owner, terrariumSize)
        {
            this.seawater = seawater;
            this.predatory = predatory;
        }


        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Fish {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine($"Terrarium size is {calcTerrariumSize()}cm3");
            if (predatory)
                sb.AppendLine($"Is predatory");
            else
                sb.AppendLine($"Isn't predatory");

            if (seawater)
                sb.AppendLine($"Lives in saltwater");
            else
                sb.AppendLine($"Does't live in saltwater");
            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }

    }
}
