using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grade_Calculator obj_grade_calculator = new Grade_Calculator();
            string name;
           


            // Get the marks from user in 4 subjects.
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your marks in Math");
            double mathMarks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your marks in Physics");
            double physicsMarks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your marks in Chemistry");
            double chemistryMarks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your marks in Computer Science");
            double computerScienceMarks = Convert.ToDouble(Console.ReadLine());

            //calculation of average marks
            //double averageMarks = (mathMarks + physicsMarks + chemistryMarks + computerScienceMarks) / 4;

            double averageMarks = obj_grade_calculator.average_marks(mathMarks, physicsMarks, chemistryMarks, computerScienceMarks);
            string grade = obj_grade_calculator.calculate_grade(averageMarks);

            try
            {
                //applying switch statement.
                switch (grade)
                {
                    case "Grade A":
                        {
                            Console.WriteLine("Excellent! Your grade is A");
                            break;
                        }
                    case "Grade B":
                        {
                            Console.WriteLine("Good! Your grade is B");
                            break;
                        }
                    case "Grade C":
                        {
                            Console.WriteLine("Satisfactory. Your grade is C");
                            break;
                        }
                    case "Grade D":
                        {
                            Console.WriteLine("Pass. Your grade is D");
                            break;
                        }
                    case "Grade F":
                        {
                            Console.WriteLine("Fail. Your grade is F");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        
        }
    }

        