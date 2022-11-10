using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class Fox :WarmBlooded
    {
        private bool JeBesná;
        
        public Fox(string name, double weight, string owner, Tuple<double, double, double> terrariumSize, bool JeBesná) : base(name, weight, owner, terrariumSize)
        {
            this.JeBesná = jebesná;
           
        }


        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Fox {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine($"Terrarium size is {calcTerrariumSize()}cm3");
            if (jebesná)
                sb.AppendLine($"Je besná");
            else
                sb.AppendLine($"Nie je besná");

            
            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }

    }
}
