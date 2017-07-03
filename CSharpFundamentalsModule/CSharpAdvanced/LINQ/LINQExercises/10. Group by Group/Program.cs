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

            var groups = listOfStudents
                .GroupBy(x => x.Group)
                .OrderBy(gr=>gr.Key);

            foreach (var group in groups)
            {
                Console.Write(group.Key + " - ");
                var sb = new StringBuilder();
                foreach (var person in group)
                {
                    sb.Append(person.Name).Append(", ");
                }
                sb.Length -= 2;
                Console.WriteLine(sb);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }
    }
}
