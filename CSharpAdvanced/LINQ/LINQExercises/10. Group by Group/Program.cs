using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var listOfStudents = new List<Person>();

            while (input != "END")
            {
                var tokens = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var currentStudent = new Person()
                {
                    Name = tokens[0] + " " + tokens[1],
                    Group = int.Parse(tokens[2])
                };

                listOfStudents.Add(currentStudent);

                input = Console.ReadLine();
            }

            listOfStudents
                .OrderBy(x => x.Group)
                .ToList()
                .GroupBy(x => x.Group)
                .ToList()
                .ForEach(x=> Console.WriteLine($"{x.Key} - "));

        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }
    }
}
