using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractTags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text != "END")
            {
                var regex = new Regex("<.+?>");

                var matches = regex.Matches(text);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }

                text = Console.ReadLine();
            }
        }
    }
}
