using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMinFunction
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> comparer = numbers =>
            {
                var min = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                return min;
            };

            Print(input, comparer);
        }

        private static void Print(int[] input, Func<int[], int> comparer)
        {
            Console.WriteLine(comparer(input));
        }
    }
}
