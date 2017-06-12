using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURLs
{
    class ParseURLs
    {
        static void Main(string[] args)
        {
            var url = Console.ReadLine();

            var urlTokens = url.Split(new[] {"://"}, StringSplitOptions.RemoveEmptyEntries);

            if (urlTokens.Length != 2 || !urlTokens[1].Contains('/'))
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var protocol = urlTokens[0];

            var index = urlTokens[1].IndexOf('/');
            var server = urlTokens[1].Substring(0, index);

            var resources = urlTokens[1].Substring(index + 1);

            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resources}");
        }
    }
}
