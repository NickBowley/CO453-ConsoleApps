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

    }


}