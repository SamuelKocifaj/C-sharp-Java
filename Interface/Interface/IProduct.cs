using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IProduct
    {
        string Label { get; set; }
        double Price { get; set; }

        double calculatePriceWithTax(object value);

    }
}
