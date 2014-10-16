using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3A
{
    public abstract class Shape
    {
        private double _length;
        private double _width;

        public abstract double Area// kallar på metoden area i klassen Ellipse eller Rectangle, beroende på valet man gjort i start menyn 
        {
            get;

        }


        public double Length// kontroelrar att _length har ett värde högre en 0 och kapslar in fältet _length
        {
            get
            {
                return _length; // returnerar högd
            }

            set
            {
                if (value <= 0)// kontroelrar att det inmatade värden är mer en 0 
                {
                    throw new ArgumentException();
                }

                _length = value;
            }

        }


        public abstract double Perimeter // Hämtar in metoden perimeter/omkrets i klassen Ellipse eller Rectangle, beroende på valet man gjort i start menyn 
        {
            get;
        }


        public double Width // kontroelrar att width har ett värde högre en 0 och kapslar in fältet _width
        {
            get
            {
                return _width; // returnerar bred 
            }

            set
            {
                if (value <= 0)// kontroelrar att det inmatade värden är mer en 0 
                {
                    throw new ArgumentException();
                }

                _width = value;
            }
        }

        protected Shape(double length, double width)//Konstruktor ser till att fälten till delas värden konstrukorn paranetar har och är skyddad
        {
            Length = length;
            Width = width;
        }

        public override string ToString() //gör om alla värden programet fåt in, till string för att kunna presenteras i konsolen   
        {
            return string.Format("\nLängd:{0, 14:} \nBredd:{1, 14:} \nOmkrets:{2, 14:.0} \nArea:{3, 14:.0}\n", Length, Width, Perimeter, Area);
        }
    }
}
