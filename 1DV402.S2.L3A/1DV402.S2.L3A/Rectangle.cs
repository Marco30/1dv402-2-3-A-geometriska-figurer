using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3A
{
    public class Rectangle : Shape
    {
        public override double Area
        {
            get
            {
                return Length * Width; //räknar ut arean 
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Length + 2 * Width; // räknar ut omkretsen 
            }
        }

        public Rectangle(double length, double width)
            : base(length, width)
        {
        }
    }
}
