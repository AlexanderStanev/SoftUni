using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var currentNumber = numbers[0];
            var count = 1;
            var biggestCount = 0;
            var biggestSequene = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (currentNumber == numbers[i])
                {
                    count++;
                }
                else
                {
                    if (count > biggestCount)
                    {
                        biggestCount = count;
                        biggestSequene = numbers[i - 1];
                    }
                    count = 1;
                }

                if (count > biggestCount)
                {
                    biggestCount = count;
                    biggestSequene = numbers[i - 1];
                }

                currentNumber = numbers[i];
            }

            for (int i = 0; i < biggestCount; i++)
            {
                Console.Write($"{biggestSequene} ");
            }
        }
    }
}
