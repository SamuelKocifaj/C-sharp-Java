using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace úloha2._2
{
    public class HourlySalaryWorker : Worker
    {
        public int Hours { get; set; }
        public double Amount { get; set; }

        public HourlySalaryWorker(string _Name, int _Age, int Hours, double Amount) : base(_Name, _Age)
        {
            this.Hours = Hours;
            this.Amount = Amount;


        }

        

        

        public override double CalcSalary()
        {
            
            
            return Amount * Hours;
        }
    }
}
