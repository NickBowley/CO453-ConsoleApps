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
            
            miles =  InputDistance("Please enter the number of miles > ");
            
            CalculateFeet();
            
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting feet to miles");
            
            feet = InputDistance("Please enter the number of feet > ");
            
            CalculateMiles();
            
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting miles to metres");
            
            miles = InputDistance("Please enter the number of miles > ");
            
            CalculateMetres();
            
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);

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

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!");
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

        

       

        

        

     

    
    


