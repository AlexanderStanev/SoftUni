using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Work_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endingDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine();

            var listOfHolidays = new List<DateTime>();

            listOfHolidays.Add(DateTime.ParseExact("01.01","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("03.03","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("01.05","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("06.05","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("24.05","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("06.09","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("22.09","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("01.11","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("24.12","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("25.12","dd.MM",CultureInfo.InvariantCulture));
            listOfHolidays.Add(DateTime.ParseExact("26.12","dd.MM",CultureInfo.InvariantCulture));

            var workingDays = 0;
            for (DateTime currentDate = startingDate; currentDate <= endingDate; currentDate = currentDate.AddDays(1))
            {
                if (!listOfHolidays.Contains(DateTime.ParseExact(currentDate.Day.ToString() + "." + currentDate.Month.ToString(),"dd.M",CultureInfo.InvariantCulture)))
                {
                    if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        workingDays++;
                        //Console.WriteLine($"{currentDate.Day}.{currentDate.Month}.{currentDate.Year}");
                    }
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
