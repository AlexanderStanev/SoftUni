using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10ToBbaseN
{
    class ConvertFromBase10ToBbaseN
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int convertingBase = int.Parse(input[0]);
            BigInteger numberInDecBase = BigInteger.Parse(input[1]);

            StringBuilder convertedNumber = new StringBuilder();

            var digits = new List<BigInteger>();
            digits.Add(numberInDecBase % convertingBase);
            var remaining = numberInDecBase / convertingBase;

            while (remaining >= convertingBase)
            {
                digits.Add(remaining % convertingBase);
                remaining /= convertingBase;
            };

            if (remaining > 0)
            {
                digits.Add(remaining);
            }

            foreach (var digit in digits)
            {
                convertedNumber.Insert(0, digit);
            }

            Console.WriteLine(convertedNumber);
        }
    }
}
