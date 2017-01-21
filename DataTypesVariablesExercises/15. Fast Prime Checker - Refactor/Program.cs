using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
{
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
{
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            Console.WriteLine($"{i} is prime -> {isPrime}");
            }
        }
    }
}
