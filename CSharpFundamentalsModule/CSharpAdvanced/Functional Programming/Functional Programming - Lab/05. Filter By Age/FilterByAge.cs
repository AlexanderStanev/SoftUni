using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dic = new Dictionary<string,long>();

            for (var i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);

                var currentName = tokens[0];
                var currentAge = long.Parse(tokens[1]);

                dic.Add(currentName, currentAge);
            }

            var condition = Console.ReadLine();
            var age = long.Parse(Console.ReadLine());
            var format = Console.ReadLine();

                if (format == "name age")
                {
                    PrintNameAge(dic, age, condition);
                }
                else if (format == "name")
                {
                    PrintName(dic, age, condition);
                }
                else
                {
                    PrintAge(dic, age, condition);
                }
        }

        private static void PrintAge(Dictionary<string, long> dic, long age, string condition)
        {
            if (condition == "older")
            {
                dic.Where(x => x.Value >= age)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Value}"));
            }
            else
            {
                dic.Where(x => x.Value < age)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Value}"));
            }
        }

        private static void PrintName(Dictionary<string, long> dic, long age, string condition)
        {
            if (condition == "older")
            {
                dic.Where(x => x.Value >= age)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Key}"));
            }
            else
            {
                dic.Where(x => x.Value < age)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Key}"));
            }

        }

        private static void PrintNameAge(Dictionary<string, long> dic, long age, string condition)
        {
            if (condition == "older")
            {
                dic.Where(x => x.Value >= age)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Key} - {x.Value}"));
            }
            else
            {
                dic.Where(x => x.Value > age)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Key} - {x.Value}"));
            }
        }
    }
}
