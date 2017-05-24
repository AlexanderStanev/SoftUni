using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    public class Students
    {
        public string Name
        {
            get; set;
        }
        public List<double> Grades
        {
            get; set;
        }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }
}
