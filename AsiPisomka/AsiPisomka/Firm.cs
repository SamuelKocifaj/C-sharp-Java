using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiPisomka
{
    public class Firm
    {
        public List<Emloyee> Employees { get; set; }
        public Firm()
        {
            Employees = new List<Emloyee>();
        }
        public void PrintEmployeesWithIncome(double income)
        {
            foreach (var employee in Employees)
            {
                if (employee.calculateSalaryNetto() >= income)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine();
                }
            }
        }
    }

}
