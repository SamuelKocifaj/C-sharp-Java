using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    public class kon : WarmBlooded
    {

        public bool zdivo�eny;
        public boll MaPodkovu;

        public kon(string name, double weight, string owner, Tuple<double, double, double> terrariumSize,bool zdivo�eny,bool MaPodkovu) : base(name, weight, owner, terrariumSize)
        {
           this.zdivo�eny = Zdivo�eny;
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
            if (zdivo�eny)
                sb.AppendLine($"Je zdivo�eny");
            else
                sb.AppendLine($"Nie je zdivo�eny");

            if (MaPodkovu)
                sb.AppendLine($"M� podkovu");
            else
                sb.AppendLine($"Nem� podkovu");

            sb.AppendLine("+++++++++++++++++++++++");
            return sb.ToString();
        }

    }
}