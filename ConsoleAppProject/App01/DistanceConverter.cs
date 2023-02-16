using System;
using System.Runtime.CompilerServices;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Nick Bowley version 0.1
    /// </author>
    public class DistanceConverter
    {
        public static double FEET_IN_MILE = 5280;
        private double miles;
        private double feet;
        public void Run()

        {
            OutputHeading();
            InputMiles();
            //CalculateFeet();
            //OutputFeet();

            
        }

        private void OutputFeet()
        {
            throw new NotImplementedException();
        }

        private void CalculateFeet()
        {
            
        }

        private void InputMiles()
        {
            Console.WriteLine("Please enter the number of miles: ");
            string input = Console.ReadLine();
            double miles = Convert.ToDouble(input);
            Console.WriteLine("Mile entered is:" + miles);
        }

        private void OutputHeading()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("    App01 Distance Converter");
            Console.WriteLine("----------------------------------");
        }
    }
}
