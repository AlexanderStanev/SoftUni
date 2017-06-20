using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"<a(.+?)>");

            var text = Console.ReadLine();
            var wholeText = new StringBuilder();
            while (text != "end")
            {
                wholeText.Append(text);
                wholeText.Append(Environment.NewLine);

                text = Console.ReadLine();
            }

            var matches = regex.Matches(wholeText.ToString());

            foreach (Match match in matches)
            {
                var currentHref = "<a" + match.Groups[1] + ">";
                var futureHref = "[URL" + match.Groups[1] + "]";
                var newText = Regex.Replace(wholeText.ToString(), currentHref, futureHref);
                newText = Regex.Replace(newText, "</a>", "[/URL]");

                Console.WriteLine(newText);

            }

        }
    }
}
