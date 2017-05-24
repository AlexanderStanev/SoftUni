namespace MathPotato
{
    using System;
    using System.Collections.Generic;

    class MathPotato
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(' ');
            var queue = new Queue<string>(kids);
            var n = int.Parse(Console.ReadLine());

            var cycles = 1;
            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    var element = queue.Dequeue();
                    queue.Enqueue(element);
                }

                if (IsPrime(cycles))
                {
                    var primeKid = queue.Peek();
                    Console.WriteLine($"Prime {primeKid}");
                }

                else
                {
                    var removedKid = queue.Dequeue();
                    Console.WriteLine($"Removed {removedKid}");
                }

                cycles++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }

        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
