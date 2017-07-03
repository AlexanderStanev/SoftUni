﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine();
            var multiplier = int.Parse(Console.ReadLine());

            var number = inputNumber.TrimStart('0');

            if (multiplier == 0 || number == "0")
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder result = new StringBuilder();

            var numberInMind = 0;
            for (int i = 0; i < number.Length; i++)
            {
                var currentDigit = number[number.Length - 1 - i] - '0';

                var resultedDigit = currentDigit * multiplier % 10 + numberInMind;
                numberInMind = 0;

                if (resultedDigit >= 10)
                {
                    numberInMind++;
                    resultedDigit -= 10;
                }

                numberInMind += currentDigit * multiplier / 10;

                //if (resultedDigit == 0 && numberInMind == 0)
                //{
                //    continue;
                //}

                result.Insert(0, resultedDigit);
            }

            if (numberInMind > 0)
            {
                result.Insert(0, numberInMind);
            }

            Console.WriteLine(result);
        }
    }
}
