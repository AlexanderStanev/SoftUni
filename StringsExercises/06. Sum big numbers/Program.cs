using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            var min = 0;
            var max = 0;

            var listOfAdditionalDigits = new List<int>();

            if (firstNumber.Length > secondNumber.Length)
            {
                min = secondNumber.Length;
                max = firstNumber.Length;

                listOfAdditionalDigits.AddRange(firstNumber.Substring(0, max - min).ToArray().Select(x => x - '0').Select(Convert.ToInt32));
            }
            else
            {
                min = firstNumber.Length;
                max = secondNumber.Length;

                listOfAdditionalDigits.AddRange(secondNumber.Substring(0, max - min).ToArray().Select(x => x - '0').Select(Convert.ToInt32));
            }
            listOfAdditionalDigits.Reverse();


            var oneInMind = 0;
            var currentLastDigit = 0;
            var lastOneInMind = 0;
            for (int i = 0; i < min; i++)
            {
                var currentFirstNumberLastDigit = firstNumber[firstNumber.Length - i - 1] - '0';
                var currentSecondNumberLastDigit = secondNumber[secondNumber.Length - i - 1] - '0';
                var sumOfCurrentDigits = currentFirstNumberLastDigit + currentSecondNumberLastDigit;

                currentLastDigit = (sumOfCurrentDigits + oneInMind) % 10;
                oneInMind = (sumOfCurrentDigits + oneInMind) / 10;

                result.Insert(0, currentLastDigit);

                lastOneInMind = oneInMind;
            }

            if (listOfAdditionalDigits.Count != 0)
            {
                foreach (var digit in listOfAdditionalDigits)
                {
                    var sumOfDigitAndMind = digit + oneInMind;
                    if (sumOfDigitAndMind >= 10)
                    {
                        result.Insert(0, (sumOfDigitAndMind) % 10);
                        oneInMind = sumOfDigitAndMind / 10;
                    }
                    else
                    {
                        result.Insert(0, sumOfDigitAndMind);
                        oneInMind = 0;
                    }
                }
            }

             if (oneInMind != 0)
            {
                result.Insert(0, oneInMind);
            }

            Console.WriteLine(result);
        }
    }
}
