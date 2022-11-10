using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class Fox :WarmBlooded
    {
        private bool JeBesn�;
        
        public Fox(string name, double weight, string owner, Tuple<double, double, double> terrariumSize, bool JeBesn�) : base(name, weight, owner, terrariumSize)
        {
            this.JeBesn� = jebesn�;
           
        }


        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Fox {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine($"Terrarium size is {calcTerrariumSize()}cm3");
            if (jebesn�)
                sb.AppendLine($"Je besn�");
            else
                sb.AppendLine($"Nie je besn�");

            
            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }

    }
}
