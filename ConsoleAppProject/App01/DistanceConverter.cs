using System;
using System.Runtime.CompilerServices;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app currently performs three functions. It converts
    /// Miles to feet, feet to miles and miles to metres.
    /// </summary>
    /// <author>
    /// Nick Bowley version 0.4
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILE = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        public string fromUnit;
        public string toUnit;

        public double fromDistance;
        public double toDistance;


        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit= FEET;
        }
        

        public void ConvertDistance()

        {

            fromUnit = selectUnit(" Please select the from distance unit > ");
            toUnit = selectUnit(" Please select the to distance unit > ");

            Console.WriteLine($" Converting {fromUnit} to {toUnit}");
            
            fromDistance =  InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();
            
            OutputDistance();
        }

        public void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET) 
            {
                toDistance = fromDistance * FEET_IN_MILE;
            }

            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILE;
            }

            if(fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }

            else if(fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }

            if(fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES; 
            }

            else if(fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
        }

        private string selectUnit(string prompt)
        {
            string choice = DisplayChioces(prompt);
            return ExecuteChoice(choice);
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChioces(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);

        }
        private void OutputDistance()
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

        

       

        

        

     

    
    


