using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            var maxFrequencyCount = 0;
            var maxFrequencyValue = 0;
            for (int i = 0; i < numbers.Length ; i++)
            {

            }
        }
    }
}
