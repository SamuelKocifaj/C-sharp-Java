using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class RTX_3090 : IProduct, IManufacturer
    {
        public string Label { get; set ; }
        public double Price { get; set; }
        public string CompanyName { get; set; }
        public string OriginCountry { get; set; }
        public string Address { get; set; }
    }
    public double CalculatePriceWithTax()
    {
        return Price + (Price / 20);
    }

    


}
