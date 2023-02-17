using System;
using System.Runtime.CompilerServices;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app currently performs three functions. It converts
    /// Miles to feet, feet to miles and miles to metres.
    /// </summary>
    /// <author>
    /// Nick Bowley version 0.2
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILE = 5280;
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feet;
        private double metres;

        public void MilesToFeet()

        {
            OutputHeading("Converting miles to feet");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting feet to miles");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting miles to metres");
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        private void InputMiles()
        {
            Console.WriteLine("Please enter the number of miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }

        private void InputFeet()
        {
            Console.WriteLine("Please enter the number of feet: ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }

        private void InputMetres()
        {
            Console.WriteLine("Please enter the number of metres: ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);

        }

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILE;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILE;
        }

        private void CalculateMetres()
        {
            metres = miles / FEET_IN_MILE;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres!");
        }



        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("    App01 Distance Converter");
            Console.WriteLine("         By Nick Bowley     ");
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

    }

}

        

       

        

        

     

    
    


