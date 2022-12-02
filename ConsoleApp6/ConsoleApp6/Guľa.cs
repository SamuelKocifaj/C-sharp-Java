using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class Guľa:Tvar
    {
        public double Objem(double R)
        {
            double ObjemGule;
            ObjemGule = 4/3*3.14 * R * R * R;
            return ObjemGule;
        }
        public double Povrch(double R)
        {
            double PovrchGule;
            PovrchGule = 4 * 3.14 * R * R;
            return PovrchGule;
        }

    }
}
