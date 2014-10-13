using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3A
{
    class Program
    {
        static void Main(string[] args)
        {
              ShapeType shapeType = ShapeType.Rectangle;

            double length = ReadDoubleGreaterThanZero("längd: "); 

            double width = ReadDoubleGreaterThanZero("bred: ");

            Shape myShape = null;

            if (shapeType == ShapeType.Rectangle)
            {
               myShape = new Rectangle(length, width);
               Console.WriteLine();
            }

            ViewShapeDetail(myShape);

        }

        private static void ViewShapeDetail(Shape shape)//
        {
           
            Console.WriteLine(shape.ToString());
            
        }
   

    private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double number;
            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();
                try
                {
                    number = double.Parse(userInput);

                    if (number <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error!!! tal ska vara större än 0!");
                        Console.ResetColor();
                    }
                    else
                    { 
                        return number; 
                    }

                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!!!, du matade inte in en siffra, ange en siffra");
                    Console.ResetColor();
                }

            }
        }

        enum ShapeType
        {
            Ellipse, 
            Rectangle,
        }

    }
}
