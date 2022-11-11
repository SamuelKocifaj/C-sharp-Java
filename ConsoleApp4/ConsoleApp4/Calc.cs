using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Calc
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Calc()
        {
            Console.WriteLine("Zavolal sa prázdny konštruktor");
        }
        public Calc(int x)
        {
            X = x;
            Console.WriteLine("Zavolal sa konštruktor pre X");
        }
        public Calc(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Zavolal sa konštruktor pre X a Y");
        }
        static void DoSomething(string s)
        {
            Console.WriteLine(s);

        }
        static void DoSomething(string x,int a)
        {
            Console.WriteLine(x);
        }
        public void DoSomething(string x, bool b)
        {
            if (b==true)
            { Console.WriteLine(x.ToUpper()); }
            else if (b==false)
            { Console.WriteLine(x.ToLower()); }
        }

    }
}
