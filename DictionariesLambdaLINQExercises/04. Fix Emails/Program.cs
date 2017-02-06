using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();

            var emails = new Dictionary<string, string>();

            while (firstInput != "stop")
            {
                var secondInput = Console.ReadLine();
                if (!secondInput.Contains(".us") && !secondInput.Contains(".uk"))
                {
                    emails[firstInput] = secondInput;
                }
                firstInput = Console.ReadLine();
            }

            foreach (var email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
