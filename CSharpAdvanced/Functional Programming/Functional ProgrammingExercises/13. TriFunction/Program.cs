using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var words = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, int> CountChars = word =>
            {
                var count = 0;
                foreach (var symbol in word)
                {
                    count += symbol;
                }
                return count;
            };

            Func<string, int, bool> isEqualOrLarger = (word, n) =>
            {
                if (CountChars(word) >= number)
                {
                    return true;
                }

                return false;
            };

            PrintStringLargerThanN(number, words, isEqualOrLarger);
        }

        private static void PrintStringLargerThanN(int number, string[] words, Func<string, int, bool> isEqualOrLarger)
        {
            foreach (var word in words)
            {
                if (isEqualOrLarger(word, number))
                {
                    Console.WriteLine(word);
                    break;
                }
            }
        }
    }
}
