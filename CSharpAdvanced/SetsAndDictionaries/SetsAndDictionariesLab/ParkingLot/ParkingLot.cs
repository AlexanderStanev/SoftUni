namespace ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class ParkingLot
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ", RegexOptions.IgnorePatternWhitespace);

                if (inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    parking.Remove(inputParams[1]);
                }

                input = Console.ReadLine();
            }

            if (parking.Count != 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car.Trim());
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
