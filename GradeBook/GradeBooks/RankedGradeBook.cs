using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name) //calling base constructor
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade) //override require virtual 
        {
            if (Students.Count()<5)
            {
                throw new InvalidOperationException();
            }
                return 'F';
        }
    }
}
