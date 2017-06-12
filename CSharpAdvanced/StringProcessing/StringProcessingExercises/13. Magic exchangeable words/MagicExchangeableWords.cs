using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var longerWord = string.Empty;
            var shorterWord = string.Empty;

            if (input[0].Length > input[1].Length)
            {
                longerWord = input[0];
                shorterWord = input[1];
            }
            else
            {
                longerWord = input[1];
                shorterWord = input[0];
            }

            var newAlphabet = new Dictionary<char, char>();

            var isExchangeable = true;
            if (longerWord.Length == shorterWord.Length)
            {
                for (int i = 0; i < shorterWord.Length; i++)
                {
                    var currentFirstChar = shorterWord[i];
                    var currentSecondChar = longerWord[i];

                    if (newAlphabet.ContainsKey(currentFirstChar))
                    {
                        if (newAlphabet[currentFirstChar] != currentSecondChar)
                        {
                            isExchangeable = false;
                        }
                    }
                    else
                    {
                        newAlphabet[currentFirstChar] = currentSecondChar;
                    }
                }

            }
            else // The words are of different length 
            {
                for (int i = 0; i < shorterWord.Length; i++)
                {
                    var currentFirstChar = shorterWord[i];
                    var currentSecondChar = longerWord[i];

                    if (newAlphabet.ContainsKey(currentFirstChar))
                    {
                        if (newAlphabet[currentFirstChar] != currentSecondChar)
                        {
                            isExchangeable = false;
                        }
                    }
                    else
                    {
                        newAlphabet[currentFirstChar] = currentSecondChar;
                    }
                }

                for (int i = shorterWord.Length + 1; i < longerWord.Length; i++)
                {
                    var currentFirstChar = longerWord[i];

                    if (!newAlphabet.ContainsValue(currentFirstChar))
                    {
                        isExchangeable = false;
                    }
                }
            }

            if (newAlphabet.Values.Distinct().Count() != newAlphabet.Values.Count())
            {
                isExchangeable = false;
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
