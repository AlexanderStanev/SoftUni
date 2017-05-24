using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        { // to fix
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers);

            var currentNumber = numbers[0];
            var currentCount = 1;
            var biggestCount = 0;
            var biggestNumber = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (currentNumber == numbers[i])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > biggestCount)
                    {
                        biggestCount = currentCount;
                        biggestNumber = numbers[i - 1];
                    }
                    currentCount = 1;
                }

                if (currentCount > biggestCount)
                {
                    biggestCount = currentCount;
                    biggestNumber = numbers[i - 1];
                }

                currentNumber = numbers[i];
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
