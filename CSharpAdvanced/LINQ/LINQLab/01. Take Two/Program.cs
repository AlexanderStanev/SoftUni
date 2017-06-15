using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

            input.Distinct()
                .Where(x => x >= 10 && x <= 20)
                .Take(2)
                .ToList()
                .ForEach(x => Console.Write(x + " "));

        }
    }
}
