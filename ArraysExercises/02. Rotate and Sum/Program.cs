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
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());

            var count = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                count[i] = 0;
            }


            for (int j = 0; j < rotations; j++)
            {
                var temp = numbers[numbers.Length - 1];
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        numbers[i] = numbers[i - 1];
                        count[i] = count[i] + numbers[i];
                    }
                    else
                    {
                        numbers[i] = temp;
                        count[i] = count[i] + numbers[i];
                    }
                }
            }
           
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{count[i]} ");
            }
        }
    }
}
