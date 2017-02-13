using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var students = new List<Students>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var currentStudent = new Students
                {
                    Name = input[0],
                    Grades = input.Skip(1).Select(double.Parse).ToList()
                };

            students.Add(currentStudent);
            }

            students = students.Where(value => value.AverageGrade >= 5).ToList();
            students = students.OrderBy(value => value.Name).ThenByDescending(value => value.AverageGrade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {Math.Round(student.AverageGrade,2,MidpointRounding.ToEven):F2}");
            }
        }
    }
}
