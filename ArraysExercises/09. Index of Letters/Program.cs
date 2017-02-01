using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.WriteLine($"{symbol} -> {symbol - 'a'}");
            }
        }
    }
}
