using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvensOdds
{
    class Program
    {
        public static void Main()
        {
            var borderNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var command = Console.ReadLine();
            var numbers = Enumerable
                .Range(borderNumbers[0], borderNumbers[1] - borderNumbers[0] + 1)
                .ToArray();

            Predicate<int> isEven = n => n % 2 == 0;
            PrintChoosenNums(numbers, command, isEven);
        }

        private static void PrintChoosenNums(int[] numbers, string command, Predicate<int> isEven)
        {
            var result = new StringBuilder();
            foreach (var number in numbers)
            {
                if (isEven(number) && command == "even")
                {
                    result.Append(number);
                    result.Append(" ");
                }

                else if (!isEven(number) && command == "odd")
                {
                    result.Append(number);
                    result.Append(" ");
                }
            }

            Console.WriteLine(result);
        }
    }
}
