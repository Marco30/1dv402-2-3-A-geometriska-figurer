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

        public abstract double Area // egenskapen Area är en abstract publik av varaibel double, har ockås figurens Area  
        { 
            get; 
        
        }


        public double Length// kontroelrar att _length har ett värde högre en 0 och kapslar in fältet _length
        {
            get 
            {
                return _length; 
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _length = value;
            }

        }


        public abstract double Perimeter // egenskapen Perimeter är en abstract publik av varaibel double, har ockås figurenss omkretsen  
        { 
            get; 
        }


        public double Width // kontroelrar att _width har ett värde högre en 0 och kapslar in fältet _width
        {
            get
            { 
                return _width; 
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _width = value;
            }
        }

        protected Shape(double length, double width)//Konstruktor skydar och ser till att fälten till delas värden konstrukorn paranetar har 
        {
            _length = length;
            _width = width;
        }

        public override string ToString() //gör om alla i variabler till text för att kunna presenteras  
        {
            return string.Format("\nLängd:{0, 14:} \nBredd:{1, 14:} \nOmkrets:{2, 14:.0} \nArea:{3, 14:.0}\n", Length, Width, Perimeter, Area);
        }
    }
}
