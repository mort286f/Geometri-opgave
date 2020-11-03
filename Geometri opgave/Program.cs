    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //instances
            Square square = new Square(5);
            Square square1 = new Square(20);
            Parallelogram parallelogram = new Parallelogram(3, 5, 20);
            Rectangle rectangle = new Rectangle(5, 10);
            Trapez trapez = new Trapez(10, 9, 8, 9);
            RightAngled_Triangle triangle = new RightAngled_Triangle(3, 4, 5);

            /*
            //calling perimeter methods
            Console.WriteLine("---Calculate Perimeter Methods---");
            Console.WriteLine(square.CalculatePerimeter());
            Console.WriteLine(square1.CalculatePerimeter());

            //calling area methods
            Console.WriteLine("---Calculate Area Methods---");
            Console.WriteLine("Square: " + square.CalculateArea());
            Console.WriteLine("Square1: " + square1.CalculateArea());
            Console.WriteLine("Parallelogram: " + parallelogram.CalculateArea());
            Console.WriteLine("Rectangle: " + rectangle.CalculateArea());
            Console.WriteLine("Trapez: " + trapez.CalculateArea());
            Console.WriteLine("Triangle: " + triangle.CalculateArea());
            */

            //creation of a list containing each figure
            List<Figure> figures = new List<Figure>();

            //adding the figures to the list one by one
            figures.Add(square);
            figures.Add(parallelogram);
            figures.Add(rectangle);
            figures.Add(trapez);
            figures.Add(triangle);

            //a foreach loop that takes each figure in the list and gets the type, area and perimeter and prints it
            foreach (var item in figures)
            {
                Console.WriteLine("\n" + "Type: " + item.GetType().Name);
                Console.WriteLine("Area: " + item.CalculateArea());
                Console.WriteLine("Perimeter: " + item.CalculatePerimeter());
            }

            Console.ReadKey();
        }
    }
}
