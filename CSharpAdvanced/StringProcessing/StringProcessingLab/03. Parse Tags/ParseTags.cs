using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {

        static void Main(string[] args)
        {
            const string startTag = "<upcase>";
            const string endTag = "</upcase>";

            var input = Console.ReadLine();

            do
            {
                var startIndex = input.IndexOf(startTag);
                var endIndex = input.IndexOf(endTag);

                if (startIndex == -1 || endIndex == -1)
                {
                    break;
                }

                var currentString = input.Substring(startIndex, endIndex + 9 - startIndex);
                var currentRemovedTagsString = currentString
                    .Replace(startTag, string.Empty)
                    .Replace(endTag, string.Empty);

                input = input.Replace(currentString, currentRemovedTagsString.ToUpper());

            } while (true);

            Console.WriteLine(input);
        }
    }
}
