using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;
using System.Diagnostics.Metrics;

namespace ConsoleAppProject
{
    
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Nick Bowley 24/02/2023
    /// </summary>
    public class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();

        public StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public NewsFeed NewsFeed
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("             Applications Programming             ");
            Console.WriteLine("                   By Nick Bowley                 ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.WriteLine(" Which App would you like to open?");
            Console.WriteLine();
            Console.WriteLine("| 1. Distance Converter");
            Console.WriteLine("| 2. BMI Calculator");
            Console.WriteLine("| 3. Student Grades");
            Console.WriteLine("| 4. Social Network");

            Console.WriteLine("Please enter your choice");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                converter.ConvertDistance();

            }
            else if (choice == "2")
            {
                calculator.ConvertBMI();

            }

            else if (choice == "3")
            {
                StudentGrades studentGrades = new StudentGrades();
                studentGrades.Run();
            }

            else if (choice == "4")
            {
                NetworkApp network = new NetworkApp();
                network.Run();
            }
            else Console.WriteLine("Invalid Choice");


            
            
        }
    }
}


           
        
    




    
    
            

            