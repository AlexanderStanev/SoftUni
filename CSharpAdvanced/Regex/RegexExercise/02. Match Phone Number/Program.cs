using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^\+359( |-)\d\1\d{3}\1\d{4}$");

            var text = Console.ReadLine();

            while (text != "end")
            {
                var matches = regex.Matches(text);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                text = Console.ReadLine();
            }
        }
    }
}
