using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            Console.WriteLine(CharacterMultiply(input[0], input[1]));

        }

        public static int CharacterMultiply(string str1, string str2)
        {
            var sum = 0;

            var maxLength = 0;
            var minLength = 0;
            var longestString = string.Empty;
            if (str1.Length > str2.Length)
            {
                maxLength = str1.Length;
                minLength = str2.Length;
                longestString = str1;
            }
            else
            {
                maxLength = str2.Length;
                minLength = str1.Length;
                longestString = str2;
            }

            for (int i = 0; i < minLength; i++)
            {
                sum += str1[i] * str2[i];
            }

            for (int i = minLength; i < maxLength; i++)
            {
                sum += longestString[i];
            }

            return sum;
        }
    }
}
