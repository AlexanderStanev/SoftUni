using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        phonebook[input[1]] = input[2];
                        break;

                    case "S":
                        if (phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                        break;

                    case "ListAll":
                        foreach (var phone in phonebook)
                        {
                            Console.WriteLine($"{phone.Key} -> {phone.Value}");
                        }
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine().Split(' ');

            }
        }
    }
}
