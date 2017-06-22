using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        public static void Main()
        {
            var guests = new List<string>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            var filters = new List<string>();
            var input = Console.ReadLine();

            while (input != "Print")
            {
                var commands = input
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Add filter":
                        filters.Add(commands[1] + " " + commands[2]);
                        break;

                    case "Remove filter":
                        filters.Remove(commands[1] + " " + commands[2]);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var commands = filter.Split(' ');

                switch (commands[0])
                {
                    case "Starts":
                        guests = guests.Where(p => !p.StartsWith(commands[2])).ToList();
                        break;

                    case "Ends":
                        guests = guests.Where(p => !p.EndsWith(commands[2])).ToList();
                        break;

                    case "Length":
                        guests = guests.Where(p => p.Length != int.Parse(commands[1])).ToList();
                        break;

                    case "Contains":
                        guests = guests.Where(p => !p.Contains(commands[1])).ToList();
                        break;
                }
            }

            if (guests.Any())
            {
                Console.WriteLine(string.Join(" ", guests));
            }
        }
    }
}
