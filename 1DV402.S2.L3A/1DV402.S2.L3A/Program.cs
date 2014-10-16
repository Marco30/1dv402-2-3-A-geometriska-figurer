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
            do // får menyn att lopa tills man väljer 0 = avsluta 
            {
                Console.Clear();//rensar konsol rutan 
                ViewMenu();// kallar på metoden viewmenu som visar meny texten

                string text = Console.ReadLine();// här mattar man in valet av meny 

                int val;

                try
                {
                    val = int.Parse(text);

                    if (val < 0 || val > 2)//kontrolerar att man har ett värde mellan 0 - 2, och kastar ett undantag som hanteras i catch
                    {
                        throw new ArgumentException();
                    }

                    if (val == 0)// välger man o så startas den här if satsen som bryter lopen 
                    {
                        Console.WriteLine();
                        break;
                    }
                    if (val == 1)// här körs programmet i alla sina faser med grafiska figuren Ellipse
                    {
                        ViewShapeDetail(CreateShape(ShapeType.Ellipse));// här används alla metoderna som skapar programmet, här kallas metoden för inmatning av läng/bred, beräkning av area/omkrets och presentation av area/omkrets

                    }
                    if (val == 2)// här körs programmet i alla sina faser med grafiska figuren Rectangle
                    {
                        ViewShapeDetail(CreateShape(ShapeType.Rectangle));

                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR!!! mata in nummer mellan 0 -2.\n");
                    Console.ResetColor();
                }

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("tryck på valfri tangent för att fortsätta ");
                Console.ReadKey();
                Console.ResetColor();

            }
            while (true);




        }

        private static Shape CreateShape(ShapeType shapeType)// här matar man in längd och bred som senan tas in i Ellipse.cs eller Rectangle.cs för att bearbetas vidare 
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n==========================================");
            Console.WriteLine("==              {0}               ==", shapeType);
            Console.WriteLine("==========================================\n");
            Console.ResetColor();

            double length = ReadDoubleGreaterThanZero("längd:");

            double width = ReadDoubleGreaterThanZero("bred:");

            Shape form = null;

            if (shapeType == ShapeType.Ellipse)
            {
                form = new Ellipse(length, width);
                Console.WriteLine();
            }
            if (shapeType == ShapeType.Rectangle)
            {
                form = new Rectangle(length, width);
                Console.WriteLine();
            }

            return form;
        }

        private static void ViewShapeDetail(Shape shape)//läser ut omkräts och area  
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n========================================");
            Console.WriteLine("=               Detaljer               =");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());

        }


        private static double ReadDoubleGreaterThanZero(string prompt)// här kontrolleras att de in matade värden i metoden CreateShape är större än 0 och inte bokstäver, blir det fel hanteras det här med ett tydligt error meddelande och en ny möjlighet att matta in värden fås 
        {
            double number;
            while (true)
            {
                Console.WriteLine(prompt);
                string text = Console.ReadLine();
                try
                {
                    number = double.Parse(text);

                    if (number <= 0) // kontrollerar att det inmatade värdet är större än 0
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

                catch//presenterar fel meddelande  om man matar in bokstäver 
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
            Console.WriteLine("==========================================");
            Console.WriteLine("=          Geometriska Figurer           =");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("\n 0. Avsluta");
            Console.WriteLine("\n 1. Ellips");
            Console.WriteLine("\n 2. Rektangel");
            Console.WriteLine("\n------------------------------------------");
            Console.Write("\n Ange menyval [0-2]:");
        }

        enum ShapeType// metode som hämtar formler utifrån den respektive Geometriska Figuren man valt.
        {
            Ellipse,
            Rectangle,
        }

    }
}
