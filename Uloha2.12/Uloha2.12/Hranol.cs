using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uloha2._12
{
    public class Hranol : Tvar
    {
        public double Sp { get; set; }
        public double Spl { get; set; }
        public double v { get; set; }

        public override double objem()
        {
            return Sp * v;
        }

        public override double povrch()
        {
            return 2 * (Sp + Spl);
        }

        public Hranol(double a, double b, double c)
        {
            Sp = a;
            Spl = b;
            v = c;
        }

    }
}
