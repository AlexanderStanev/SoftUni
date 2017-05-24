using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

            var listOfAdditionalDigits = new List<BigInteger>();

            if (firstNumber.Length > secondNumber.Length)
            {
                min = secondNumber.Length;
                max = firstNumber.Length;

                listOfAdditionalDigits.AddRange(firstNumber.Substring(0, max - min).ToArray().Select(x => BigInteger.Parse((x - '0').ToString())));
            }
            else
            {
                min = firstNumber.Length;
                max = secondNumber.Length;

                listOfAdditionalDigits.AddRange(secondNumber.Substring(0, max - min).ToArray().Select(x => BigInteger.Parse((x - '0').ToString())));
            }
            listOfAdditionalDigits.Reverse();


            BigInteger oneInMind = 0;
            BigInteger currentLastDigit = 0;
            BigInteger lastOneInMind = 0;
            for (int i = 0; i < min; i++)
            {
                BigInteger currentFirstNumberLastDigit = firstNumber[firstNumber.Length - i - 1] - '0';
                BigInteger currentSecondNumberLastDigit = secondNumber[secondNumber.Length - i - 1] - '0';
                BigInteger sumOfCurrentDigits = currentFirstNumberLastDigit + currentSecondNumberLastDigit;

                currentLastDigit = (sumOfCurrentDigits + oneInMind) % 10;
                oneInMind = (sumOfCurrentDigits + oneInMind) / 10;

                result.Insert(0, currentLastDigit);

                lastOneInMind = oneInMind;
            }

            if (listOfAdditionalDigits.Count != 0)
            {
                foreach (var digit in listOfAdditionalDigits)
                {
                    BigInteger sumOfDigitAndMind = digit + oneInMind;
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
