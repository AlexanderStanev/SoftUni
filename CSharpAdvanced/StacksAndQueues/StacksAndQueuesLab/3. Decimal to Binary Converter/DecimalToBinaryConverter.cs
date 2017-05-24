namespace DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;

    class DecimalToBinaryConverter
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            var decimalNumberString = Console.ReadLine();
            var decimalNumber = int.Parse(decimalNumberString);

            if (decimalNumberString == "0")
            {
                Console.WriteLine(0);
                return;
            }

            else
            {
                var flag = true;

                do
                {
                    if (decimalNumber == 1)
                    {
                        flag = false;
                    }

                    var reminder = decimalNumber % 2;
                    stack.Push(reminder);
                    decimalNumber /= 2;
                } while (flag);
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}
