using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            IsPrime(n);
        }

        private static void IsPrime(long n)
        {
            if (false)
            {
                Console.WriteLine("True");
            }
            else if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
