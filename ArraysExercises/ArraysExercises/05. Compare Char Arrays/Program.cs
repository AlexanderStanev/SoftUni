using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            if (firstInput.Length < secondInput.Length)
            {
                //Console.WriteLine("The first input char array is shorter");
                PrintArray(firstInput.Length,firstInput);
                PrintArray(secondInput.Length, secondInput);
            }

            else if (secondInput.Length < firstInput.Length)
            {
                //Console.WriteLine("The second input char array is shorter");
                PrintArray(secondInput.Length, secondInput);
                PrintArray(firstInput.Length, firstInput);
            }

            else
            {
                //Console.WriteLine("The sizes of the arrays are equal");

                for (int i = 0; i < firstInput.Length; i++)
                {
                    if (secondInput[i] < firstInput[i])
                    {
                       //Console.WriteLine("The second input is shorter");
                        PrintArray(secondInput.Length, secondInput);
                        PrintArray(firstInput.Length, firstInput);
                        break;
                    }
                    else if (firstInput[i] < secondInput[i])
                    {
                        //Console.WriteLine("The first input is shorter");
                        PrintArray(firstInput.Length, firstInput);
                        PrintArray(secondInput.Length, secondInput);
                        break;
                    }

                    if (i == firstInput.Length - 1)
                    {
                        PrintArray(firstInput.Length, firstInput);
                        PrintArray(secondInput.Length, secondInput);
                    }
                }
            }
        }

        private static void PrintArray(int inputLength, string text)
        {
            for (int i = 0; i < inputLength; i++)
            {
                if (text[i] != ' ')
                {
                    Console.Write(text[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
