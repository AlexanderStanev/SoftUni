using System;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader("../../OtherTextFile.txt"))
            {
                using (var sw = new StreamWriter("../../EmptyTextFile.txt"))
                {
                    for (var i = 0; !sr.EndOfStream; i++)
                    {
                        sw.WriteLine(sr.ReadLine());
                    }

                    Console.WriteLine($"The file has been saved"); // Also numbering them
                }
            }
        }
    }
}
