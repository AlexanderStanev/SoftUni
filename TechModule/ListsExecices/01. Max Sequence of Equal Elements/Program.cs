using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(int.Parse(input[i]));
            }

            var currentNumber = numbers[0];
            var currentCount = 1;
            var bestCount = 0;
            var startingIndex = 0;
            var bestStartingIndex = 0;
            var bestEndingIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (currentNumber == numbers[i]) // if its the same number count++ to the current sequence
                {
                    currentCount++;
                }
                else // else check if this is sequence is better than the current one
                {
                    if (currentCount > bestCount) // if it is make the count the best count for now
                    {
                        bestCount = currentCount;
                        bestStartingIndex = startingIndex;
                        bestEndingIndex = i;
                    }

                    startingIndex = i;
                    currentCount = 1;
                }

                currentNumber = numbers[i];
            }

            if (currentCount > bestCount) // final check if the best sequence are the last numbers of the lsit
            {
                bestCount = currentCount;
                bestStartingIndex = startingIndex;
                bestEndingIndex = numbers.Count;
            }

            for (int i = bestStartingIndex; i < bestEndingIndex; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
