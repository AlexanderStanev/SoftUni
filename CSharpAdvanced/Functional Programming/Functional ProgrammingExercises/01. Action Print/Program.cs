using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint
{
    class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(' ');

            Action<string> print = str => Console.WriteLine(str);

            PrintAllNames(names, print);
        }

        private static void PrintAllNames(string[] names, Action<string> print)
        {
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
