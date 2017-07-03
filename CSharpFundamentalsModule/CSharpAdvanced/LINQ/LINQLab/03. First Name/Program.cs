using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var lettersInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var letters = new SortedSet<string>(lettersInput);

            var name = string.Empty;
            foreach (var letter in letters)
            {
                name = names
                    .FirstOrDefault(w => w.ToLower()
                        .StartsWith(letter.ToLower()));

                if (name == null)
                {
                    continue;
                }

                Console.WriteLine(name);
                break;
            }

            if (name == null)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
