using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            var sum = 0.0;
            foreach (var word in words)
            {
                var firstLetter = word.Substring(0, 1).First();
                var number = double.Parse(word.Substring(1, word.Length - 2));
                var secondLetter = word.Substring(word.Length - 1).First();

                var currentSum = 0.0;
                if (char.IsUpper(firstLetter))
                {
                    currentSum = number / (firstLetter - '@');
                }
                else
                {
                    currentSum = number * (char.ToUpper(firstLetter) - '@');
                }

                if (char.IsUpper(secondLetter))
                {
                    currentSum -=  secondLetter - '@';
                }
                else
                {
                    currentSum += char.ToUpper(secondLetter) - '@';
                }

                sum += currentSum;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
