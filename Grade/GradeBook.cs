using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public GradeStatistics ComputeStatistics ()
        {
            GradeStatistics states = new GradeStatistics();
            float sum = 0;
            foreach (float grade in grades)
            {
                states.HighestGrade = Math.Max(grade, states.HighestGrade);
                states.LowestGrade = Math.Min(grade,states.LowestGrade);

                sum += grade;
            }
            states.AverageGrade = sum / grades.Count;
            return states;
         }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;
    }
}
