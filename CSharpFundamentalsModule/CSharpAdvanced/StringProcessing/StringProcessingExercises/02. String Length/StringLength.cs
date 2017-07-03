using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine(input.PadRight(20,'*'));
        }
    }
}
