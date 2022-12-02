using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class Kocka : Tvar
    {
        public  double Objem(double A)
        {
            double ObjemKocky ;
            ObjemKocky = A * A * A;
            return ObjemKocky;
        }

        public  double Plocha(double A)
        {
            double PlochaKocky;
            PlochaKocky = 6 * A * A;
            return PlochaKocky;
        }
    }
}
