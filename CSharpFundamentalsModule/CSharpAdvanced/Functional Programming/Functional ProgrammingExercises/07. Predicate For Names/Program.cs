using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var maximumLength = int.Parse(Console.ReadLine());

            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> isPrintable = name => name.Length <= maximumLength;

            PrintReversedArray(input, isPrintable);
        }

        private static void PrintReversedArray(string[] names, Predicate<string> isPrintable)
        {
            foreach (var name in names)
            {
                if (isPrintable(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
