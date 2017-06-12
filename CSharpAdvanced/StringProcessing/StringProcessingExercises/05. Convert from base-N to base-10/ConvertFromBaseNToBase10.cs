using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var baseN = ulong.Parse(input[0]);
            var numberToConvertoDec = input[1];

            var listOfNumbers = new List<BigInteger>();
            var result = new BigInteger();
            for (int i = 0; i < numberToConvertoDec.Length; i++)
            {
                BigInteger currentDigit = numberToConvertoDec[i] - '0';
                result += BigInteger.Parse((currentDigit * BigInteger.Pow(baseN, numberToConvertoDec.Length - i - 1)).ToString());
            }

            Console.WriteLine(result);
        }
    }
}
