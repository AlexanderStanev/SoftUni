using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        RandomList rndList = new RandomList
        {
            "a", "b", "c", "d"
        };

        Console.WriteLine(rndList.RandomString());

        Console.WriteLine("Remaining elements: " + string.Join(" " ,rndList.ToArray()));
    }
}
