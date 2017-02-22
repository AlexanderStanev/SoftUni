using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonLengthInDays = ulong.Parse(Console.ReadLine());
            var numberOfRunners = ulong.Parse(Console.ReadLine());
            var averageNumberOfLaps = ulong.Parse(Console.ReadLine());
            var lapLenght = ulong.Parse(Console.ReadLine());
            var trackCapacity = uint.Parse(Console.ReadLine());
            var moneyDonatedPerKilometer = decimal.Parse(Console.ReadLine());
            var moneyDonatedPerMeter = moneyDonatedPerKilometer / 1000;

            var totalMoneyRaised = 0M;


            if (numberOfRunners > trackCapacity * marathonLengthInDays)
            {
                numberOfRunners = trackCapacity * marathonLengthInDays;
            }


            totalMoneyRaised = numberOfRunners * lapLenght * averageNumberOfLaps * moneyDonatedPerMeter;
            Console.WriteLine($"Money raised: {totalMoneyRaised:F2}");

        }
    }
}
