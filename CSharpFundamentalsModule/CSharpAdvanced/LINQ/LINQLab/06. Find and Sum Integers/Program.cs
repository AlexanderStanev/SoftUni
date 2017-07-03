using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var sum = 0.0;
            var hasAtLeastOneNumber = false;
            foreach (var characters in input)
            {
                var result = 0.0;
                var isNumber = double.TryParse(characters, out result);

                if (!isNumber)
                {
                    continue;
                }

                sum += result;
                hasAtLeastOneNumber = true;
            }

            if (hasAtLeastOneNumber)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
