using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long lastDigit = input % 10;

            Console.WriteLine(ReadLastDigit(lastDigit));
        }

        private static string ReadLastDigit(long digit)
        {
            switch (digit)
            {
                case 1:
                    return "one" ;
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 0:
                    return "zero";
                default:
                    return "greshka";
            }
        }
    }
}
