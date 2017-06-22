﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsFirstLastName
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
                .Where(x => string.Compare(x[0], x[1], StringComparison.OrdinalIgnoreCase) <= 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
