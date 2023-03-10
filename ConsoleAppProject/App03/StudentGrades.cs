using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03

{
    ///App03 Student Marks will allow a tutor to
    /// enter a single mark for eah of a list of
    /// students and convert that mark into a grade
    /// It also calculates simple statistic and
    /// displays a student grade profile
    /// 
    public class StudentGrades
    {
       //Declaring Contants
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestGrade = 100;

        public string[] Students { get; set; }

        public int[] GradeClass { get; set; }
        public int[] Marks { get; set; }
       
        /// <summary>
        /// This method will run the programme and output a heading
        /// </summary>
        public void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                ConsoleHelper.OutputHeading("Student Grades");
                //StudentGrades();
                //repeat = ConsoleHelper.WantToRepeat();
            }
        }
        /// <summary>
        /// This method includes the names of the students, and runs the input, output and calculate methods 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Nick",
                "Nicholas",
                "Nicola",
                "Nicky",
                "Nico",
                "Bob",
                "Robert",
                "Rob",
                "Robby",
                "Bob"
            };

            GradeClass = new int[(int)App03.Grades.A + 1];
            Marks = new int[Students.Length];
            
            InputMarks();
            OutputMarks();

        }
        /// <summary>
        /// This method will allow the user to input the percentage for each of the listed students
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputTitle("Enter Mark for Student");
            Console.WriteLine("Enter the Percentage for the below students:");

            for (int index = 0; < Students.Length; index++)
            {
                Marks[index] = (int)ConsoleHelper.InputNumber($"" +
                    $"{Students[index]} > ", 0, 100);
            }
        }


    }