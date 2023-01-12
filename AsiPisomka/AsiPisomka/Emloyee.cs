using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiPisomka
{
    public class Emloyee : Person
    {
       public double SalaryBrutto { get; set; }
        public Emloyee(string _firstname, string _lastname, int _age, double _height, double _salaryBrutto) : base(_firstname, _lastname, _age, _height)
        {
            this.SalaryBrutto = SalaryBrutto;
        }

        
        public  double calculateSalaryNetto()
        {
            return SalaryBrutto + (SalaryBrutto/70.15);
        }
        public double calculateIncomeTax()
        {
            return SalaryBrutto - (SalaryBrutto/16.45);
        }
        public double calculateInsurance()
        {
            return SalaryBrutto - (SalaryBrutto / 13.45);
        }
        
    }
}
