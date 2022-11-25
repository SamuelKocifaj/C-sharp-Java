using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Rectangle:Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override double getArea()
        {
            return X * Y;
        }

        public override double getPerimeter()
        {
            return 2*(X+Y) ;
        }
        public override void drawObject()
        {
            for (int x = 0; x < X; x++)
            {
                for (int i = 0; i < Y; i++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine(" ");
            }
            return;
        }
    }
}
