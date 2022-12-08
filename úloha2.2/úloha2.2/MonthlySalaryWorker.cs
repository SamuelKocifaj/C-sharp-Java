using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace úloha2._2
{
    public class MonthlySalaryWorker : Worker
    {
        public int Bonus { get; set; }
        public double MonthSalary { get; set; }
        public MonthlySalaryWorker(string _Name, int _Age,int Bonus,double MonthSalary) : base(_Name, _Age)
        {
            this.Bonus= Bonus;
            this.MonthSalary= MonthSalary;
        }

        public override double CalcSalary()
        {
            return MonthSalary + (Bonus * (Age * 0.2));
        }
    }
}
