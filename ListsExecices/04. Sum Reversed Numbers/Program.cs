using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split();
            var reversedNumberList = new List<int>();

            foreach (var number in numbers)
            {
                reversedNumberList.Add(ReverseNumber(number));
            }

            Console.WriteLine(string.Join("", reversedNumberList));
        }

        private static int ReverseNumber(string currentNumber)
        {
            var reversedNumberList = new List<char>();

            for (int i = currentNumber.Length - 1; i >= 0; i--)
            {
                reversedNumberList.Add(currentNumber[i]);
            }

            var reversedNumber = int.Parse(String.Join(" ", reversedNumberList));
            return reversedNumber;
        }
    }
}
