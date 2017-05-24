namespace DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DecimalToBinaryConverter
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            var decimalNumberString = Console.ReadLine();

            if (decimalNumberString == "0")
            {
                Console.WriteLine(0);
            }

            else
            {
                for (int i = 0; i < decimalNumberString.Length; i++)
                {
                    var currentDigit = decimalNumberString[i] - '0';
                    var reminder = currentDigit % 2;
                    stack.Push(reminder);
                }
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}
