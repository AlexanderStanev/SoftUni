namespace BalancedParenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();

            var input = Console.ReadLine();

            var flag = true;

            foreach (var symbol in input)
            {
                if (!flag)
                {
                    break;
                }

                switch (symbol)
                {
                    case '{':
                        stack.Push('{');
                        break;

                    case '[':
                        stack.Push('[');
                        break;

                    case '(':
                        stack.Push('(');
                        break;

                    case '}':
                        if (stack.Count > 0)
                        {
                            CheckIfMatched('{', stack);
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        break;

                    case ']':
                        if (stack.Count > 0)
                        {
                            CheckIfMatched('[', stack);
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        break;

                    case ')':
                        if (stack.Count > 0)
                        {
                            CheckIfMatched('(', stack);
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        break;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static void CheckIfMatched(char symbol, Stack<char> stack)
        {
            if (symbol == stack.Peek())
            {
                stack.Pop();
                return;
            }
            else
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
                return;
            }
        }
    }
}
