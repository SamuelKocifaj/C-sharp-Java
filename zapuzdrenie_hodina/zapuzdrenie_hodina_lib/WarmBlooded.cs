using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapuzdrenie_hodina_lib
{
    class WarmBlooded : Animal
    {
        public double BodyTemp { get; set; }
        public Tuple<double, double, double> TerrariumSize { get; set; }
        public WarmBlooded(string name, double weight, string owner,double bodytemp ,Tuple<double, double, double> terrariumSize) : base(name, weight, owner)
        {
            this.TerrariumSize = terrariumSize;
            this.BodyTemp = bodytemp;
        }

        protected double calcTerrariumSize()
        {
            return this.TerrariumSize.Item1 * this.TerrariumSize.Item2 * this.TerrariumSize.Item3;
        }


        public override string ToString()
        {
            return this.Owner + this.name;
        }
    }
}

