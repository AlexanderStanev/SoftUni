using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var rotations = int.Parse(Console.ReadLine());

            var stringArray = input.Split();

            var numbersArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                numbersArray[i] = int.Parse(stringArray[i]);
            }

            int temp = numbersArray[numbersArray.Length-2];
            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                numbersArray[i] = temp;
                temp = numbersArray[i - 1];
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine(numbersArray[i]);
            }
        }
    }
}
