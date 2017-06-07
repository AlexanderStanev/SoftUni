using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();

            var wordsFromFile = new string[] { };
            using (var sr = new StreamReader("../../Words.txt"))
            {
                wordsFromFile = sr.ReadToEnd()
                    .Split(new[] { ' ', '\n', '-', '.', ',', '!', '?', ';', '`', '\'', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>x.ToLower())
                    .ToArray();
            }

            var wordsFromTextFile = new string[] { };
            using (var sr = new StreamReader("../../TextFile.txt"))
            {
                wordsFromTextFile = sr.ReadToEnd()
                    .Split(new[] { ' ', '\n', '-', '.', ',', '!', '?', ';', '`', '\'', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLower())
                    .ToArray();
            }

            AddInDictionary(dic, wordsFromFile, wordsFromTextFile);

            using (var sw = new StreamWriter("../../Result.txt", true))
            {
                foreach (var kvp in dic.OrderByDescending(x => x.Value)) 
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value} has been written to the file");
                    sw.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }

        private static void AddInDictionary(Dictionary<string, int> dic, string[] wordsFromFile, string[] wordsFromTextFile)
        {
            foreach (var word in wordsFromTextFile)
            {
                if (wordsFromFile.Any(x => x.Equals(word)))
                {
                    if (!dic.ContainsKey(word))
                    {
                        dic.Add(word, 0);
                    }

                    dic[word]++;
                }
            }
        }
    }
}
