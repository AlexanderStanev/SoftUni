namespace SequenceWithQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            var queue = new Queue<long>();

            var firstNumber = long.Parse(Console.ReadLine());

            queue.Enqueue(firstNumber);

            for (long i = 0; i < 50; i++)
            {
                var currentElement = queue.Dequeue();
                Console.Write(currentElement + " ");

                var elementToEnqueue = currentElement + 1;
                queue.Enqueue(elementToEnqueue);

                elementToEnqueue = 2 * currentElement + 1;
                queue.Enqueue(elementToEnqueue);

                currentElement = currentElement + 2;
                queue.Enqueue(currentElement);
            }
        }
    }
}
