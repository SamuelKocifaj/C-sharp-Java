using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace úloha2._2
{
    public abstract class Worker : Person

        
    {
        protected Worker(string _Name, int _Age) : base(_Name, _Age)
        {
        }

        public abstract double CalcSalary();
     

        
        
        

       
    }
}
