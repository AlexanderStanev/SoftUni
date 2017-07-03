namespace ReverseStrings
{
    using System;
    using System.Collections.Generic;

    class ReverseStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            var result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                result += stack.Pop();
            }

            Console.WriteLine(result);
        }
    }
}
