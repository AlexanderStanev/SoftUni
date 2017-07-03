using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var divider = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = number => number % divider == 0;

            PrintReversedArray(input, isDivisible);
        }

        private static void PrintReversedArray(int[] numbers, Predicate<int> isDivisible)
        {
            foreach (var number in numbers.Reverse())
            {
                if (!isDivisible(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
