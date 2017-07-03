using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            var count = 0;
            for (int index = 0; index <= text.Length - substring.Length; index++)
            {
                var currnetSubstring = text.Substring(index, substring.Length);
                if (currnetSubstring == substring)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
