using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace úloha2._2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string _Name, int _Age)
        {
            this.Name = _Name;
            this.Age = _Age;
        }
    
    }
}
