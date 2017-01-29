using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var array = new long[n];

            array[0] = 1;

            for (int i = 0; i < n; i++)
            {
                if (k >= i)
                {
                    for (int j = 0; j < i; j++)
                    {
                        array[i] += array[j];
                    }
                }
               else
                {
                    for (int j = 0; j <= k; j++)
                    {
                        array[i] += array[i - j];
                    }
                }
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
        }
    }
}
