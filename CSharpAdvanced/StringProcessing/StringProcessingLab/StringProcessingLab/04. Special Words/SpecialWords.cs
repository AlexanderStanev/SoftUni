using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialWords
{
    class SpecialWords
    {
        static void Main(string[] args)
        {
            var specialWords = new Dictionary<string, int>();

            var wordsInput = Console.ReadLine();
            var words = wordsInput
                .Split(new[] { ' ', ',', '(', ')', '[', ']', '<', '>', '-', '!', '?' },
                    StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine()
                .Split(new[] { ' ', ',', '(', ')', '[', ']', '<', '>', '-', '!', '?' },
                    StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (!specialWords.ContainsKey(word))
                {
                    specialWords.Add(word, 0);
                }
            }

            foreach (var word in text)
            {
                if (specialWords.ContainsKey(word))
                {
                    specialWords[word]++;
                }
            }

            foreach (var kvp in specialWords)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
