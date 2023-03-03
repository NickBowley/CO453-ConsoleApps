using System;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App asks the user which unit of distance they would like to convert
    /// from and to, it the completes the conversion.
    /// </summary>
    /// <author>
    /// Nick Bowley version 0.5
    /// </author>

    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        /// <summary>
        /// This method allows the user to make thier choice of unit to and from.
        /// It also outputs the heading for the app.
        /// </summary>
        /// 
       

        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Selecting units");
            string[] choices = new string[]
            {
                FEET, METRES, MILES
            };

            Console.WriteLine($"\n Please select a unit to convert from\n");
            int choice = ConsoleHelper.SelectChoice(choices);
            FromUnit = choices[choice - 1];
            Console.WriteLine($"\n You have selected {FromUnit}! ");

            Console.WriteLine($"\n Please select a unit to convert to\n");
            choice = ConsoleHelper.SelectChoice(choices);
            ToUnit = choices[choice - 1];
            Console.WriteLine($"\n You have selected {ToUnit}! ");

            FromDistance = ConsoleHelper.InputNumber($"\n Please enter the number of" +
                $" {FromUnit} you wish to convert to {ToUnit} > ");

            ConsoleHelper.OutputTitle($"\n Converting {FromUnit} to {ToUnit} ");
            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// This method completes the calculations required.
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// This method shows the user the choices available for conversion from and to.
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine("\n");
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// This method converts to a double after reading it from the user input.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// This method shows the user the converted to and from distance
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit}" +
                $" is {ToDistance} {ToUnit}!");
        }   
    }
}