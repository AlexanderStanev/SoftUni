using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(int.Parse(Console.ReadLine())));
        }

        static int Fibonacci(int x)
        {
            if (x <= 2)
                return 1;
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
    }
}
