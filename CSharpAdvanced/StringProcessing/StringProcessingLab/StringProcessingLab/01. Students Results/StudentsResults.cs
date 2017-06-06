using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsResults
{
    class StudentsResults
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());

            var dic = new Dictionary<string, double[]>();

            for (int i = 0; i < students; i++)
            {
                var currnetStudentTokens = Console.ReadLine().Split(new[] {' ', '-', ','},StringSplitOptions.RemoveEmptyEntries);

                dic.Add(currnetStudentTokens[0], new[]
                    {
                        double.Parse(currnetStudentTokens[1]),
                        double.Parse(currnetStudentTokens[2]),
                        double.Parse(currnetStudentTokens[3])
                    });
            }

            Console.WriteLine("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average");
            foreach (var student in dic)
            {
                Console.WriteLine($"{student.Key,-10}|{student.Value[0],7:F2}|{student.Value[1],7:F2}|{student.Value[2],7:F2}|{student.Value.Average(),7:F4}|");
            }
        }
    }
}
