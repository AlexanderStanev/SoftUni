using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            var firstStringArray = new string[firstInput.Length];
            var secondStringArray = new string[secondInput.Length];

            firstStringArray = firstInput.Split(' ');
            secondStringArray = secondInput.Split(' ');

            int min;
            if (firstStringArray.Length < secondStringArray.Length)
            {
                min = firstStringArray.Length;
            }
            else 
            {
                min = secondStringArray.Length;
            }


            var countFromLeft = 0;
            for (int i = 0; i < min; i++)
            {
                if (firstStringArray[i] == secondStringArray[i])
                {
                    countFromLeft++;
                }
            }

            var countFromRight = 0;
            for (int i = 0; i < min; i++)
            {
                if (firstStringArray[firstStringArray.Length-i -1] == secondStringArray[secondStringArray.Length-i-1])
                {
                    countFromRight++;
                }
            }

            if (countFromLeft > countFromRight)
            {
                Console.WriteLine(countFromLeft);
            }
            else
            {
                Console.WriteLine(countFromRight);
            }
        }
    }
}
