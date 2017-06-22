using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJohn
{
    class Program
    {
        const int lines = 4;
        private const string longArrow = ">>>----->>";
        private const string mediumArrow = ">>----->";
        private const string shortArrow = ">----->";

        static void Main(string[] args)
        {
            var longArrows = 0;
            var mediumArrows = 0;
            var shortArrows = 0;

            for (var i = 0; i < lines; i++)
            {
                var line = Console.ReadLine();
                while (true)
                {
                    if (line.Contains(longArrow))
                    {
                        longArrows++;
                        line = RemoveArrow(line, longArrow);
                    }
                    else if (line.Contains(mediumArrow))
                    {
                        mediumArrows++;
                        line = RemoveArrow(line, mediumArrow);
                    }
                    else if (line.Contains(shortArrow))
                    {
                        shortArrows++;
                        line = RemoveArrow(line, shortArrow);
                    }
                    else break;
                }
            }

            var arrowsToDec = string.Concat(shortArrows, mediumArrows, longArrows);

            var arrowToBinary = Convert
                .ToString(long.Parse(arrowsToDec), 2);

            var reversedArrowToBinary = new string(arrowToBinary.Reverse().ToArray());
                
            var reversedArrowAndNormalArrowBinary = arrowToBinary + reversedArrowToBinary;

            var result = Convert.ToInt32(reversedArrowAndNormalArrowBinary, 2);
            Console.WriteLine(result);
        }

        private static string RemoveArrow(string line, string arrowType)
        {
            var removeStartIndex = line.IndexOf(arrowType);
            var removeEndIndex = arrowType.Length;

            line = line.Remove(removeStartIndex, removeEndIndex);

            return line;
        }
    }
}
