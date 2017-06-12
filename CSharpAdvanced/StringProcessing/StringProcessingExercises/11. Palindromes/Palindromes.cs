using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var palindromes = new SortedSet<string>();

            var words = Console.ReadLine()
                .Split(new [] {' ', ',', '.', '?', '!'},
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                var reversedWord = new string(word.Reverse().ToArray());

                if (word == reversedWord)
                {
                    palindromes.Add(word);
                }
            }

            var joinedOutput = string.Join(", ", palindromes);
            Console.WriteLine($"[{joinedOutput}]");
        }
    }
}
