using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var splittedNumbers = Console.ReadLine()
                .Split(new[] {',', ' ', '\t', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(splittedNumbers
                .Count());

            Console.WriteLine(splittedNumbers
                .Sum());
        }
    }
}
