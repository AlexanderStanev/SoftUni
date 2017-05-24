namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var reminder = expression.Split(' ');
            var stack = new Stack<string>(reminder.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operation = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }

                else
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
