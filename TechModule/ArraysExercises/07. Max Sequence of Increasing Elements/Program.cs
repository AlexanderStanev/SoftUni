namespace MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()// ni bachka...
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var currentNumber = numbers[0];
            var currentSequenceLength = 1;
            var bestLength = 0;
            var bestStartingIndex = 0;
            var currentIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (currentNumber < numbers[i])
                {
                    currentSequenceLength++;
                    if (currentSequenceLength > bestLength)
                    {
                        bestLength = currentSequenceLength;
                        bestStartingIndex = currentIndex;
                    }
                }

                else
                {
                    currentIndex = i + 1;
                    currentSequenceLength = 1;
                }

                currentNumber = numbers[i];
            }

            for (int i = bestStartingIndex; i < bestStartingIndex + bestLength; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
