using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted) //calling base constructor
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade) //override require virtual 
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            var percent20 = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.Select(x => x.AverageGrade).OrderByDescending(x => x).ToList();

            if (averageGrade >= grades[percent20 - 1])
            {
                return 'A';
            }
            else if (averageGrade >= grades[(percent20 * 2) - 1])
            {
                return 'B';
            }
            else if (averageGrade >= grades[(percent20 * 3) - 1])
            {
                return 'C';
            }
            else if (averageGrade >= grades[(percent20 * 4) - 1])
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        public override void CalculateStatistics()
        {

            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");

            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");

            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
