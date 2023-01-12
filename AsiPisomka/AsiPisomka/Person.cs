using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiPisomka
{
   public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        double Height { get; set; }
        public Person(string _firstname, string _lastname, int _age, double _height) 
        { 
            this.FirstName = _firstname;
            this.LastName = _lastname;
            this.Age = _age;
            this.Height = _height;

        }
        public override string ToString()
        {
            String message = "-----------";
            Console.WriteLine(message);
            Console.WriteLine("Meno: "+FirstName);
            Console.WriteLine("Priezvysko: "+LastName);
            Console.WriteLine("Vek: "+Age);
            Console.WriteLine("Výška: "+Height);
            return message;
        }
    }
}
