using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var endReached = false;
            while (!endReached) // LET THE CYCLE CONTINUE
            {
                var input = Console.ReadLine();

                var commands = input.Split();

                switch (commands[0])
                {
                    case "exchange":
                        var index = int.Parse(commands[1]);

                        if (index < 0 || index >= initialArray.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            initialArray = Exchange(initialArray,index);
                        }
                        break;

                    case "max":
                        FindMinMaxElement(initialArray, commands[0], commands[1]);
                        break;

                    case "min":
                        FindMinMaxElement(initialArray, commands[0], commands[1]);
                        break;

                    case "first":
                        FindFirstLastElements(initialArray, commands[0], commands[1], commands[2]);
                        break;

                    case "last":
                        FindFirstLastElements(initialArray, commands[0], commands[1], commands[2]);
                        break;

                    case "end":
                        Console.WriteLine("["+ string.Join(", ", initialArray) + "]");
                        endReached = true;
                        break;
                }
            }
        }

        private static void FindFirstLastElements(int[] initialArray, string firstOrLast, string count, string oddOrEven)
        {
            List<int> filter = MakeOddOrEvenList(initialArray, oddOrEven);

            if (initialArray.Length < long.Parse(count))
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (firstOrLast == "first")
            {
                var numbersToPrint = filter.Take(int.Parse(count));

                Console.WriteLine("[" + string.Join(", ", numbersToPrint) + "]"); 
            }
            else if(firstOrLast == "last")
            {
                var numbersToPrint = filter.Skip(filter.Count - int.Parse(count));

                Console.WriteLine("[" + string.Join(", ", numbersToPrint) + "]");
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private static void FindMinMaxElement(int[] initialArray, string maxOrMin, string oddOrEven)
        {
            var elementIndex = 0;

            List<int> filter = MakeOddOrEvenList(initialArray, oddOrEven);

            if (maxOrMin == "max")
            {
                var elementValues = filter.Where(x => x == filter.Max()).ToList();

                if (elementValues.Count == 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }

                elementIndex = initialArray.ToList().LastIndexOf(elementValues.Last());
            }
            else if (maxOrMin == "min")
            {
                var elementValues = filter.Where(x => x == filter.Min()).ToList();

                if (elementValues.Count == 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }

                elementIndex = initialArray.ToList().LastIndexOf(elementValues.Last());
            }
            else
            {
                throw new ArgumentException();
            }

            Console.WriteLine(elementIndex);
        }

        private static List<int> MakeOddOrEvenList(int[] initialArray, string oddOrEven)
        {
            var filter = new List<int>();
            if (oddOrEven == "odd")
            {
                filter = initialArray.Where(x => x % 2 != 0).ToList();

            }
            else if (oddOrEven == "even")
            {
                filter = initialArray.Where(x => x % 2 == 0).ToList();
            }
            else
            {
                throw new ArgumentException();
            }

            return filter;
        }

        private static int[] Exchange(int[] initialArray, int index)
        {
            var leftSide = initialArray.Take(index + 1);
            var rightSide = initialArray.Skip(index + 1);

            var result = rightSide.Concat(leftSide).ToArray();

            return result;
        }
    }
}
