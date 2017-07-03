using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsEnrolled2014Or2015
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
                .Where(x => x[0][4] == '1' && (x[0][5] == '4' || x[0][5] == '5'))
                .ToList()
                .ForEach(x => Console.WriteLine(x[1] + " " + x[2] + " " + x[3] + " " + x[4]));
        }
    }
}
