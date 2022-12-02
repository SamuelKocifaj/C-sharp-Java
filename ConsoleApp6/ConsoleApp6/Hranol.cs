using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class Hranol:Tvar
    {
        public double Povrch(double SP,double O,double v)
        {
          
            double ObsahPlasta;
            ObsahPlasta = O * v;
            double PovrchKvadra;
            PovrchKvadra = 2 * SP + ObsahPlasta;
            return ObsahPlasta;
        }

        public double Objem(double SP, double v)
        {
            double ObjemKvadra;
            ObjemKvadra= SP * v;
            return ObjemKvadra;
        }
    }
}
