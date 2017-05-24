using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_sentences_by_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentancesWordPatter = Console.ReadLine();
            var text = Console.ReadLine();
            var sentancesSplitPatern = @"[.!?]";
            var wordsSplitPatter = @"\W";

            Regex regex = new Regex(sentancesSplitPatern);

            var sentances = Regex.Split(text, sentancesSplitPatern);

            var words = new List<string>();
            foreach (var sentance in sentances)
            {
                words = Regex.Split(sentance,wordsSplitPatter).ToList();

                if (words.Contains(sentancesWordPatter))
                {
                    Console.WriteLine(sentance.Trim());
                }
            }
        }
    }
}
