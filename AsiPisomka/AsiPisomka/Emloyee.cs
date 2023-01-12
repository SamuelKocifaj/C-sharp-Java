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
            SalaryBrutto = _salaryBrutto;
        }

        
        public  double calculateSalaryNetto()
        {
            return (SalaryBrutto/100) *70.15;
        }
        public double calculateIncomeTax()
        {
            return (SalaryBrutto/100) *16.45;
        }
        public double calculateInsurance()
        {
            return (SalaryBrutto/100) *13.40;
        }
        public override string ToString()
        {
            return "Name: " + FirstName + "\nSurname: " + LastName + "\nAge" + Age + "\nHeight" + Height +"\nBrutto salary: " + SalaryBrutto + "\nNettoSalary: " + calculateInsurance() + "\nIncome Tax: "
                + calculateIncomeTax() + "\nInsurance: " + calculateInsurance();
        }
    }
}
