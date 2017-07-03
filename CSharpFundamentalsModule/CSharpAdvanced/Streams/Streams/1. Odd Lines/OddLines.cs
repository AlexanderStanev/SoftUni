using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader("../../TextFile.txt"))
            {
                for (var i = 0; !sr.EndOfStream; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"{i}. {sr.ReadLine()}"); // Also numbering them
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
            }
        }
    }
}
