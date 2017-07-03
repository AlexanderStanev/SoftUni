using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentancesWordPatter = Console.ReadLine();
            var text = Console.ReadLine();

            var regex = new Regex($@".+?{sentancesWordPatter}.+?[!.?]{1}",RegexOptions.Singleline);

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
