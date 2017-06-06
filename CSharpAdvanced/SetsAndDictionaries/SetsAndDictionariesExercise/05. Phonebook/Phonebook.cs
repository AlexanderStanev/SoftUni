namespace Phonebook
{
    using System;
    using System.Collections.Generic;

    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            do
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {
                    return;
                }

                if (input == "search")
                {
                    break;
                }

                var comand = input.Split('-');
                var contactName = comand[0];
                var contactNumber = comand[1];

                if (phonebook.ContainsKey(contactName))
                {
                    phonebook[contactName] = contactNumber;
                }
                else
                {
                    phonebook.Add(contactName, contactNumber);
                }

            } while (true);

            do
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {
                    return;
                }

                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }

            } while (true);
        }
    }
}