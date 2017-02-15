using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var convertingBase = int.Parse(input[0]);
            var numberInDecBase = input[1];

            StringBuilder convertedNumber = new StringBuilder();

            foreach (var character in numberInDecBase)
            {
                if (character >= convertingBase)
                {
                    //convertedNumber.Insert(0,character)
                }
            }
        }
    }
}
