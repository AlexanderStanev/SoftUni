using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (var character in input)
            {
                sb.Insert(0, character);
            }

            Console.WriteLine(sb);
        }
    }
}
