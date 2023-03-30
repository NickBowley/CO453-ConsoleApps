using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// App03 Student Marks will allow a tutor to
    /// enter a single mark for eah of a list of
    /// students and convert that mark into a grade
    /// It also calculates simple statistic and
    /// displays a student grade profile
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }
        public int Maximum { get; set; }

        /// <summary>
        /// This method will run the program, outputting a
        /// heading, closing the program if the user does
        /// not wish to run it again
        /// </summary>
        public void Run()
        {
                ConsoleHelper.OutputHeading("Student Grades");
                //StudentGrades()
        }

        /// <summary>
        /// This method holds the names of the students. It
        /// runs the methods to input the marks, output the
        /// marks, calculate the stats, and calculate the
        /// grade profile, of each student
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Nick", "Philip", "Adam", "Louise",
                "Jess", "Mike", "Chris", "Mary",
                "Ella", "Will"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

            InputMarks();
            OutputMarks();
            CalculateStats();
            CalculateGradeProfile();
        }

        /// <summary>
        /// This method allows the user to input a mark
        /// between 0 - 100 for each student an store it
        /// in the Marks array
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputTitle(" Entering Student Marks");
            Console.WriteLine(" Please enter a percentage mark for " +
                "the following students:");

            for (int index = 0; index < Students.Length; index++)
            {
                Marks[index] = (int)ConsoleHelper.InputNumber($" {Students[index]} > ", 0, 100);
            }
        }

        /// <summary>
        /// This method lists all the students and displays
        /// their name and current mark
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle(" Student Marks");

            for (int index = 0; index < Students.Length; index++)
            {
                Grades grade = ConvertToGrade(Marks[index]);
                string name = EnumHelper<Grades>.GetName(grade);

                Console.WriteLine($" {Students[index]} {Marks[index]}% - Grade {grade} | {name}");
            }
        }
        /// <summary>
        /// This method converts a student mark to a grade
        /// from F (Fail) to A (First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else
            {
                return Grades.None;
            }
        }

    









