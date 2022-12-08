using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uloha2._12
{
    public class Guľa : Tvar
    {
        public double d { get; set; }

        public override double objem()
        {
            return 3.14 * (d * d);
        }

        public override double povrch()
        {
            return (3.14 / 6) * (d * d * d);

        }
        public Guľa(double bla)
        {
            d = bla;
        }
    }
}
