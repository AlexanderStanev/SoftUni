using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());

            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPricePerKilo = decimal.Parse(Console.ReadLine());

            var portions = guests / 6;
            if (guests % 6 != 0)
            {
                portions++;
            }

            var portionCost = 2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPricePerKilo;
            var totalCost = portionCost * portions;

            if (money >= totalCost)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalCost - money):F2}lv more.");
            }
        }
    }
}
