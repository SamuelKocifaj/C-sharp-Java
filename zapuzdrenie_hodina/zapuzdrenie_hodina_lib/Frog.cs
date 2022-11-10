using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class Frog : ColdBlooded
    {

        public int Legs { get; set; }
        public bool isHybernating { get; set; }
        public bool isPoisonous { get; set; }

        public Frog(string name, double weight, string owner, Tuple<double, double, double> terrariumSize, int legs, bool ishybernating, bool ispoisonous) : base(name, weight, owner, terrariumSize)
        {
            this.isHybernating = ishybernating;
            this.Legs = legs;
            this.isPoisonous = ispoisonous;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Frog {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"Has {Legs} legs");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine($"Terrarium size is {calcTerrariumSize()}m3");
            if (isHybernating)
                sb.AppendLine($"Is hybernating");
            else
                sb.AppendLine($"Isn't hybernating");

            if (isPoisonous)
                sb.AppendLine($"Is poisonous");
            else
                sb.AppendLine($"Isn't poisonous");

            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }

    }
}
