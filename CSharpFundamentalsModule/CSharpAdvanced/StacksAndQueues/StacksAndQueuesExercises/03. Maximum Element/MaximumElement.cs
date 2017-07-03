namespace MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MaximumElement
    {
        static void Main(string[] args)
        {
            var numberOfQueries = int.Parse(Console.ReadLine());

            var allNumbersStack = new Stack<int>();
            var maximumNumbersStack = new Stack<int>();

            var maximumNumber = int.MinValue;

            for (int i = 0; i < numberOfQueries; i++)
            {
                var query = Console.ReadLine().Split(' ');
                if (query[0] == "1")
                {
                    var elementToPush = int.Parse(query[1]);
                    allNumbersStack.Push(elementToPush);

                    if (maximumNumber <= elementToPush)
                    {
                        maximumNumber = elementToPush;
                        maximumNumbersStack.Push(maximumNumber);
                    }
                }

                else if (query[0] == "2")
                {
                    if (maximumNumbersStack.Contains(allNumbersStack.Peek()))
                    {
                        allNumbersStack.Pop();

                        if (maximumNumbersStack.Count != 0)
                        {
                            maximumNumber = maximumNumbersStack.Pop();
                        }

                        else
                        {
                            maximumNumber = int.MinValue;
                        }
                    }
                    else
                    {
                        allNumbersStack.Pop();
                    }
                    
                }

                else if (query[0] == "3")
                {
                    Console.WriteLine(maximumNumber);
                }

                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
