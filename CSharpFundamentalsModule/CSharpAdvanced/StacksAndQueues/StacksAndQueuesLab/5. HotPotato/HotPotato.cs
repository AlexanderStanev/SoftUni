using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(' ');
            var queue = new Queue<string>(kids);
            var n = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    var element = queue.Dequeue();
                    queue.Enqueue(element);
                }

                var removedKid = queue.Dequeue();
                Console.WriteLine($"Removed {removedKid}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
