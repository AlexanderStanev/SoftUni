using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
           var input = Console.ReadLine().Trim();

            var regex = new Regex(@"\s([a-zA-Z0-9]+?[\w.-]+?@[a-zA-Z]{1}[a-zA-Z-]+?(\.[a-zA-Z]{1}[a-zA-Z-]+?)+)[,.!?\s]");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
