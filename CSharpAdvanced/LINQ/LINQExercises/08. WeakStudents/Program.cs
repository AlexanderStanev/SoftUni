using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakStudents
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
                .Where(x =>
                {
                    var count = 0;

                    for (var i = 2; i < x.Length; i++)
                    {
                        if (int.Parse(x[i]) <= 3)
                        {
                            count++;
                        }
                    }

                    return count >= 2;
                })
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
