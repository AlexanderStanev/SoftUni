﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hexNumber = Convert.ToString(number, 16).ToUpper();
            string binaryNumber = Convert.ToString(number, 2);

            Console.WriteLine(hexNumber);
            Console.WriteLine(binaryNumber);
        }
    }
}
