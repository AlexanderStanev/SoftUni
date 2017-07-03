using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string[], string[], string[]> func = (array, commandTokens) =>
            //{
            //};

            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var command = new string[] {};
            while (command[0] != "Party!")
            {

                command = Console.ReadLine()
                    .Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
