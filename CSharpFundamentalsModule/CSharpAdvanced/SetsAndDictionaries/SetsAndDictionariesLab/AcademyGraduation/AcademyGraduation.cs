namespace AcademyGraduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AcademyGraduation
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var students = new SortedDictionary<string, double>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var currentStudent = Console.ReadLine();
                var marks = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                var averegeMark = marks.Average();

                students.Add(currentStudent, averegeMark);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");
            }
        }
    }
}
