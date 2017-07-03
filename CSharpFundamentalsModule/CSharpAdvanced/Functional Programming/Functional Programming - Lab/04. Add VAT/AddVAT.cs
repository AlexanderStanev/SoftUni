using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList()
                .ForEach(x => Console.WriteLine($"{120.0 / 100.0 * x:F2}"));
        }
    }
}
