using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            { //??
                throw new InvalidOperationException("Minimum expected number of students: 5.");
                int StudentsNo = Students.Count;
                var change = Math.Round(StudentsNo * 0.2); //<- ilość studentów wchodzących w 20% (w górę czy w dół?)

                //if (averageGrade >= 90)
                //    return 'A';
                //else if (averageGrade >= 80)
                //        return 'B';
                //    else if (averageGrade >= 70)
                //        return 'C';
                //    else if (averageGrade >= 60)
                //        return 'D';
                //    else
                //        return 'F';
            }
        }
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Ranked;
            {
            }

        }
    }
}
