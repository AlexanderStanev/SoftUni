using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output = string.Empty;
            foreach (var character in input)
            {
                output += "\\u" + ((int)character).ToString("X").PadLeft(4, '0');
            }

            Console.WriteLine(output.ToLower());
        }
    }
}
