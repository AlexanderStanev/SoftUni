using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var stops = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var checkpointsIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            foreach (var driver in drivers)
            {
                var remainingFuel = (double)driver[0];

                for (int i = 0; i < stops.Count; i++)
                {
                    if (checkpointsIndexes.Contains(i))
                    {
                        remainingFuel += stops[i];
                    }
                    else
                    {
                        remainingFuel -= stops[i];
                    }

                    if (remainingFuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if (remainingFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {remainingFuel:F2}");
                }
            }
        }

    }
}