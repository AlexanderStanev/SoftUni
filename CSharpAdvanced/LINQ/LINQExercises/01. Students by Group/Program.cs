using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new [] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                var firstName = input[0];
                var secondName = input[1];
                var group = input[2];
            }
        }
    }
}
