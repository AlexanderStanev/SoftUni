using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var totalSteps = long.Parse(Console.ReadLine());
            var secondsForStep = long.Parse(Console.ReadLine());

            var totalSecondsForAllSteps = totalSteps * secondsForStep % 60;
            var totalMinutesForAllSteps = totalSteps * secondsForStep / 60 % 60;
            var totalHoursForAllSteps = totalSteps * secondsForStep / 60 / 60;
            totalHoursForAllSteps = totalHoursForAllSteps % 24;

            timeOfLeaving = timeOfLeaving.AddSeconds(totalSecondsForAllSteps);
            timeOfLeaving = timeOfLeaving.AddMinutes(totalMinutesForAllSteps);
            timeOfLeaving = timeOfLeaving.AddHours(totalHoursForAllSteps);

            Console.WriteLine($"Time Arrival: {timeOfLeaving.Hour:00}:{timeOfLeaving.Minute:00}:{timeOfLeaving.Second:00}");
        }
    }
}

