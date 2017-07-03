using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var regex = new Regex("[AEIOUYaeiouy]");

            var count = regex.Matches(text).Count;

            Console.WriteLine($"Vowels: {count}");
        }
    }
}
