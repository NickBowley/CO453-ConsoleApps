using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
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
    /// Derek Peacock 05/02/2022
    /// </summary>
    public class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();


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

            else Console.WriteLine("Invalid Choice");


            
            
                    }
            

            
        }

        

        




        }


           
        
    




    
    
            

            