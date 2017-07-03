using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    class Program
    {
        private static void Main(string[] args)
        {
            Func<int[], string, int[]> function = (numbers, action) =>
            {
                switch (action)
                {
                    case "add":
                        for (var i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]++;
                        }
                        return numbers;

                    case "multiply":
                        for (var i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] *= 2;
                        }
                        return numbers;

                    case "subtract":
                        for (var i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }
                        return numbers;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        return numbers;

                    default:
                        return numbers;
                }
            };

            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var command = Console.ReadLine();

            while (command != "end")
            {
                IterateArray(input, command, function);
                command = Console.ReadLine();
            }

        }

        private static void IterateArray(int[] input, string command, Func<int[], string, int[]> iterateArray)
        {
            iterateArray(input, command);
        }
    }
}
