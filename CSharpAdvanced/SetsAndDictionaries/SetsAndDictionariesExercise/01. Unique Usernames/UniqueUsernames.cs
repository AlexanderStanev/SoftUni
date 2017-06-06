namespace UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                set.Add(Console.ReadLine());
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
