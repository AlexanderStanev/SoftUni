using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =  int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(CompareInt(CompareInt(a, b) ,CompareInt(b, c)));

        }

        private static int CompareInt(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
