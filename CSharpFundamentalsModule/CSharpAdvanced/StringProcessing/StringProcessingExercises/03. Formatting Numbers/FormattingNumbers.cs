using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new [] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var a = int.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);

            var hexadecimal = a.ToString("X");
            var binary = Convert.ToString(a, 2);

            Console.WriteLine(@"|{0, -10}|{1}|{2, 10:F2}|{3, -10:F3}|", hexadecimal,
                binary.PadLeft(10, '0').Substring(0, 10), b, c);
        }
    }
}
