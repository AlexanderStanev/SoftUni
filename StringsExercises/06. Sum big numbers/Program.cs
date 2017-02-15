using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            StringBuilder result = new StringBuilder();


            var temp = 0;
            var sumedDigit = 0;
            var min = Math.Min(firstNumber.Length, secondNumber.Length);
            for (int i = min - 1; i >= 0; i--)
            {
                var currentFirstNumberLastDigit = int.Parse(firstNumber.Substring(i - 1 , i));
                var currentSecondNumberLastDigit =  int.Parse(secondNumber.Substring(i -1  , i));
                var sumOfCurrentDigit = currentFirstNumberLastDigit + currentSecondNumberLastDigit; 
                do
                {
                    sumedDigit += sumOfCurrentDigit % 10 + temp;
                    temp = sumOfCurrentDigit / 10;

                } while (sumedDigit >= 10);

                result.Insert(0, sumedDigit);
            }

            if (temp != 0)
            {
                result.Insert(0, temp);
            }

            Console.WriteLine(result);
        }
    }
}
