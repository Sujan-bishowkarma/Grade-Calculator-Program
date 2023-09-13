using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator_Program
{
    internal class Grade_Calculator
    {
        public string name { get; set; }
        public double mathMarks { get; set; }
        public double physicsMarks { get; set; }
        public double chemistryMarks { get; set; }
        public double computerScienceMarks { get; set; }

        public double average_marks(double mathMarks, double physicsMarks, double chemistryMarks, double computerScienceMarks)
        {
            // calculation of average marks.
            return (mathMarks + physicsMarks + chemistryMarks + computerScienceMarks) / 4;
        }
        public string calculate_grade(double averageMarks)
        {
            string grade;
            // find out the grade of the student using the average marks
            if (averageMarks >= 80)
            {
                grade = "Grade A";
            }
            else if (averageMarks >= 70 && averageMarks < 80)
            {
                grade = "Grade B";
            }
            else if (averageMarks >= 60 && averageMarks < 70)
            {
                grade = "Grade C";
            }
            else if (averageMarks >= 50 && averageMarks < 60)
            {
                grade = "Grade D";
            }
            else if (averageMarks < 50)
            {
                grade = "Grade F";
            }
            else
            {
                grade = "Invalid";
            }
            return grade;




        }
    }
}



    
