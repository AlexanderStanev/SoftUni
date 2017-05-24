using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            CalculateFigure(figure);
        }

        private static void CalculateFigure(string figure)
        {
            double side, height, width, radius;
            switch (figure)
            {
                case "triangle":

                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{ side * height / 2:F2}");
                    break;

                case "square":

                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{side * side:F2}");

                    break;

                case "rectangle":

                    width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{ width * height:F2}");

                    break;

                case "circle":

                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.PI * radius * radius:F2}");

                    break;

                default:
                    break;
            }
        }
    }
}
