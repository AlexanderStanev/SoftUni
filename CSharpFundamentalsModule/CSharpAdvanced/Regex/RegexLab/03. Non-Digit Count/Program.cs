using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NonDigitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var regex = new Regex("[\\D]");

            var count = regex.Matches(text).Count;

            Console.WriteLine($"Non-digits: {count}");
        }
    }
}
