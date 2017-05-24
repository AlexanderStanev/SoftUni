using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"([^0-9]+)(\d+)");

            var characters = new HashSet<char>();
            var result = new StringBuilder();
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var text = string.Empty;
                for (var i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    if (i == 0)
                    {
                        text = match.Groups[1].Value.ToUpper();
                        for (var j = 0; j < text.Length; j++)
                        {
                            characters.Add(text[j]);
                        }
                    }

                    result.Append(text);
                }
            }

            Console.WriteLine("Unique symbols used: " + characters.Count);
            Console.WriteLine(result);
        }
    }
}
