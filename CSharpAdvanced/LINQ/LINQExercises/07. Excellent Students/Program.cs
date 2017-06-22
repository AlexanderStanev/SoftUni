using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var studentRecords = new List<string[]>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                studentRecords.Add(tokens);

                input = Console.ReadLine();
            }

            studentRecords
                .Where(x => int.Parse(x[2]) == 6 || int.Parse(x[3]) == 6 || int.Parse(x[4]) == 6 || int.Parse(x[5]) == 6)
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
