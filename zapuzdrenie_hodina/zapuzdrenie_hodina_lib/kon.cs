using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class kon : WarmBlooded
    {

        public bool zdivoèeny;
        public boll MaPodkovu;

        public kon(string name, double weight, string owner, Tuple<double, double, double> terrariumSize,bool zdivoèeny,bool MaPodkovu) : base(name, weight, owner, terrariumSize)
        {
           this.zdivoèeny = Zdivoèeny;
           this.MaPodkovu = mapodkovu;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("+++++++++++++++++++++++");
            sb.AppendLine($"Kon {name}");
            sb.AppendLine($"Owner {Owner}");
            sb.AppendLine($"Weights {Weight}kg");
            sb.AppendLine($"Terrarium size is {calcTerrariumSize()}m3");
            if (zdivoèeny)
                sb.AppendLine($"Je zdivoèeny");
            else
                sb.AppendLine($"Nie je zdivoèeny");

            if (MaPodkovu)
                sb.AppendLine($"Má podkovu");
            else
                sb.AppendLine($"Nemá podkovu");

            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }

    }
}