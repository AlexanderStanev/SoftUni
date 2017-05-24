using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float distanceInKilometers = distanceInMeters / 1000;
            float distanceInMiles = distanceInKilometers / 1.609f;
            float totalSeconds = seconds + minutes * 60 + hours * 3600;
            

            Console.WriteLine(Math.Round(distanceInMeters / totalSeconds, 7));
            Console.WriteLine(Math.Round(distanceInKilometers / totalSeconds * 3600, 7));
            Console.WriteLine(Math.Round(distanceInMiles / totalSeconds * 3600, 7)); 


            //Console.WriteLine($"{distanceInMeters/totalSeconds:F7}");
            //Console.WriteLine($"{distanceInKilometers/totalSeconds*3600:F7}");
            //Console.WriteLine($"{distanceInMiles/totalSeconds*3600:F7}");




        }
    }
}
