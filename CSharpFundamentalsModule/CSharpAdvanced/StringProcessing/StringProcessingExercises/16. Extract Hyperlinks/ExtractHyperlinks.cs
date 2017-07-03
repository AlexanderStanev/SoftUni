using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        // Not Really Working
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var text = new StringBuilder();

            while (input != "END")
            {
                text.Append(input);
                text.Append(" ");
                input = Console.ReadLine();
            }

            //Console.WriteLine();

            input = text.ToString();

            var firstAnchorIndex = 0;
            var lastAnchorIndex = 0;

            while (true)
            {
                firstAnchorIndex = input.IndexOf("<a ", firstAnchorIndex);
                lastAnchorIndex = input.IndexOf("</a>", lastAnchorIndex);

                if (firstAnchorIndex != -1 && lastAnchorIndex != -1)
                {
                    var substring = input.Substring(firstAnchorIndex + 3, lastAnchorIndex - firstAnchorIndex - 4);
                    var substringStartIndex = substring.IndexOf("href") + 4;

                    if (substringStartIndex != -1)
                    {
                        var substringEndIndex = substring.IndexOf("\"", substringStartIndex + 1);

                        if (substringEndIndex != -1)
                        {
                            substring = substring.Substring(substringStartIndex + 1, substringEndIndex - substringStartIndex - 1);
                            Console.WriteLine(substring);
                        }
                    }

                    firstAnchorIndex++;
                    lastAnchorIndex++;
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine(text);
        }
    }
}