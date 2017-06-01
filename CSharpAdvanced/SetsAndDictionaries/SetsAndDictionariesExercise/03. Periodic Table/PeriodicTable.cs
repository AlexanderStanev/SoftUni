namespace PeriodicTable
{
    using System;
    using System.Collections.Generic;

    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var set = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var compounds = Console.ReadLine().Split();

                foreach (var compound in compounds)
                {
                    set.Add(compound);
                }
            }

            Console.WriteLine(string.Join(" ", set)); 
        }
    }
}
