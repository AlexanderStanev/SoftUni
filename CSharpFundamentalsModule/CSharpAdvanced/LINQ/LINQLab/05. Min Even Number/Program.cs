using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse);

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine(evenNumbers.Count != 0 ? $"{evenNumbers.Min():F2}" : "No match");
        }
    }
}
