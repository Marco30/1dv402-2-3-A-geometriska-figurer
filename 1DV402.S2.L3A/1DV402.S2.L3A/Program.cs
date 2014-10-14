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
            bool slut = false; 

            do
            {
                Console.Clear();
                ViewMenu();

                string text = Console.ReadLine();
                
                int val;

                try
                {
                    val = int.Parse(text);

                    if (val < 0 || val > 2)//kontrolerar att man har ett värde mellan 0 - 2, och kastar ett undantag som hanteras i catch
                    {
                        throw new ArgumentException();
                    }

                   if(val==0)
                   {
                            Console.WriteLine();
                            break;
                   }
                    if(val==1)
                   {
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                        
                            
                   }
                    if (val == 2)
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
           
            }
            while (slut == false);
          

            

        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.WriteLine("du valde:{0}", shapeType);

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
        Console.WriteLine("==========================================");
        Console.WriteLine("==============     Meny     ==============");
        Console.WriteLine("==========================================");
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
