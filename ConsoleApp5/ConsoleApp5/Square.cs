using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Square:Shape
    {
        public double X { get; set; }
        

        public override double getArea()
        {
            return X*X;
        }

        public override double getPerimeter()
        {
            return 4*X;
        }

        public override void drawObject()
        {
            for (int x = 0; x < X; x++) 
            {
                for(int i = 0; i < X; i++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine(" ");
            }
            return;
        }

    }
}
