using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            CubeProperties(cubeSide, property);
        }

        private static void CubeProperties(double cubeSide, string property)
        {
            double faceDiagonal = Math.Sqrt(cubeSide * cubeSide * 2);
            double spaceDiagonal = Math.Sqrt(cubeSide * cubeSide * 3);
            double volume = Math.Pow(cubeSide, 3);
            double area = 6 * cubeSide * cubeSide;

            switch (property)
            {
                case "face":
                    Console.WriteLine($"{faceDiagonal:F2}"); break;
                case "space":
                    Console.WriteLine($"{spaceDiagonal:F2}"); break;
                case "volume":
                    Console.WriteLine($"{volume:F2}"); break;
                case "area":
                    Console.WriteLine($"{area:F2}"); break;
            default:
                    break;
            }

        }
    }
}
