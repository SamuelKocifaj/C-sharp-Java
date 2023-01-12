using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiPisomka
{
   public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public Person(string _firstname, string _lastname, int _age, double _height) 
        { 
            this.FirstName = _firstname;
            this.LastName = _lastname;
            this.Age = _age;
            this.Height = _height;

        }
        public override string ToString()
        {
            return "Name: " + FirstName + "\nSurname: " + LastName + "\nAge" + Age + "\nHeight" + Height;
        }
    }
}
