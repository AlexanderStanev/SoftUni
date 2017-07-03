using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var newText = string.Empty;
            var lastSymbol = '\0';
            foreach (var character in text)
            {
                if (character != lastSymbol)
                {
                    newText += character;
                }

                lastSymbol = character;
            }

            Console.WriteLine(newText);
        }
    }
}
