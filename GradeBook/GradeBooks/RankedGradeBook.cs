using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public override char GetLetterGrade(double averageGrade)
        {
            if ( Students.Count < 5)
           
                throw new InvalidOperationException("Expected number of students: 5 or more.");

                int StudentsNo = Students.Count;
                var change = (int)Math.Ceiling(StudentsNo * 0.2); //<- ilość studentów wchodzących w 20% (zaokrąglenie w dół do całości)
                var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
                // - 1 bo widełki np. od 20% do 39%( 40-1)
                if (grades[(change - 1)] <= averageGrade) //w 80-100%
                    return 'A';
                else if (grades[(change *2) - 1] <= averageGrade) // w 60%-79%
                    return 'B';
                else if (grades[(change *3) - 1] <= averageGrade) // w 40%-59%
                    return 'C';
                else if (grades[(change * 4) - 1] <= averageGrade) // w 20%-39%
                    return 'D';
                else
                    return 'F'; // w 0%-19%

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
        public override void CalculateStatistics()
        { if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {   if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else base.CalculateStudentStatistics(name);
        }
        public RankedGradeBook(string name, bool IsWeighted) : base(name, IsWeighted)
        {
            this.Type = GradeBookType.Ranked;
            {
            }

        }
    }
}

