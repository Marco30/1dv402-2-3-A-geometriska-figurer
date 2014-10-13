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
            ViewMenu();

            ShapeType shapeType = ShapeType.Ellipse;

            double length = ReadDoubleGreaterThanZero("längd: "); 

            double width = ReadDoubleGreaterThanZero("bred: ");

            Shape myShape = null;

            if (shapeType == ShapeType.Ellipse)
            {
               myShape = new Ellipse(length, width);
               Console.WriteLine();
            }

            ViewShapeDetail(myShape);

        }

        private static void ViewShapeDetail(Shape shape)//läser ut omkräts och area  
        {
           
            Console.WriteLine(shape.ToString());
            
        }


        private static double ReadDoubleGreaterThanZero(string prompt)// här kontrolleras att de in matade värden är större än 0 och inte bokstäver, blir det fel hanteras det här med ett tydligt error meddelande och en ny möjlighet att matta in värden fås 
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

    private static void ViewMenu()//visar texten som blir menyn
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("-----------------Meny---------------------");
        Console.WriteLine("------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("\n 0. Avsluta");
        Console.WriteLine("\n 1. Ellips");
        Console.WriteLine("\n 2. Rektangel");
        Console.WriteLine("------------------------------------------");
        Console.Write("\n Ange menyval [0-2]:");
    }

        enum ShapeType
        {
            Ellipse, 
            Rectangle,
        }

    }
}
