using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var stackOfStrings = new StackOfStrings();

        stackOfStrings.Push("a");
        Console.WriteLine($"Popped element - {stackOfStrings.Pop()}");
        Console.WriteLine($"Peeked element - {stackOfStrings.Peek()}");
        Console.WriteLine($"Is empty - {stackOfStrings.IsEmpty()}");
        Console.WriteLine(string.Join(" ", stackOfStrings));
    }
}
