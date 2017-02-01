using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxSequence = new List<int>();
            var input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                maxSequence.Add(int.Parse(input[i]));
            }

            foreach (var number in maxSequence)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            var counters = new List<int>();
            foreach (var number in maxSequence)
            {
                if (true)
                {

                }
            }

        }
    }
}
