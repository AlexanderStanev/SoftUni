namespace SoftUniParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SoftUniParty
    {
        static void Main(string[] args)
        {
            var allGuests = new SortedSet<string>();

            var input = Console.ReadLine();

            var partyHasStarted = false;
            while (input != "END")
            {
                if (input == "PARTY")
                {
                    partyHasStarted = true;
                }
                else
                {
                    if (partyHasStarted)
                    {
                        allGuests.Remove(input);
                    }
                    else
                    {
                        allGuests.Add(input);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(allGuests.Count());
            foreach (var item in allGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
