namespace MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    var startingIndex = stack.Pop();

                    Console.WriteLine(input.Substring(startingIndex, i - startingIndex + 1));
                }
            }
        }
    }
}
