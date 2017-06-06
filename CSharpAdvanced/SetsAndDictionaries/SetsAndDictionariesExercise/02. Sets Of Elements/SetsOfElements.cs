namespace SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SetsOfElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var n = input[0];
            var m = input[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            var joinedSet = new HashSet<int>(firstSet.Concat(secondSet));

            foreach (var number in joinedSet)
            {
                if (firstSet.Contains(number) && secondSet.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
