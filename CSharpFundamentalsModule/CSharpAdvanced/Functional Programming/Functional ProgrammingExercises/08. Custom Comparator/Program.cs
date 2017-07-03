using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(Int32.Parse)
                .ToArray();

            Array.Sort(numbers, (x, y) =>
                {
                    if (x % 2 == 0 && y % 2 != 0)
                        return -1;

                    if (x % 2 != 0 && y % 2 == 0)
                        return 1;

                    if (x > y)
                        return 1;

                    if (x < y)
                        return -1;

                    return 0;
                }
            );

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
