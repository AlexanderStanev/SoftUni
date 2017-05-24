namespace ReverseNumbers
{
    using System;
    using System.Collections.Generic;

    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var numbers = input.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(int.Parse(number));
            }

            foreach (var number in numbers)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
