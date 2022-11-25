using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Triangle:Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double vX { get; set; }


        public override double getArea()
        {
            return (X*vX)/2;
        }

        public override double getPerimeter()
        {
            return X+Y+Z;
        }
        public override void drawObject()
        {
            for (int x = 0; x < X; x++)
            {
                for (int i = 0; i < Y; i++)
                {
                   for(int j = 0; j < Z; j++)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine(" ");
                }
            }
            return;
        }

    }
}
