namespace BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');

            var numbersToPush = int.Parse(firstLine[0]);
            var numbersToPop = int.Parse(firstLine[1]);
            var elementToCheck = int.Parse(firstLine[2]);

            var stack = new Queue<int>();

            var secondLine = Console.ReadLine().Split(' ');

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Enqueue(int.Parse(secondLine[i]));
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Dequeue();
            }

            if (stack.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
