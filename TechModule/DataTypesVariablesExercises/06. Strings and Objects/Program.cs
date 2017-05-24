using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strings_and_Objectse
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = "Hello";
            string secondInput = "World";
            object output = firstInput + " " + secondInput;
            string newString = (string)output;

            Console.WriteLine(newString);


        }
    }
}
