using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Uloha2._12
{
    public class Kocka : Tvar
    {
        public double A { get; set; }
        public override double povrch()
        {
            return 6 * (A * A);
        }

        public override double objem()
        {
            return A * A * A;
        }

        public Kocka( double neviem)
        {
            A = neviem; 
        }
    }
}
