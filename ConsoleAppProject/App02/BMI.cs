﻿using ConsoleAppProject.Helpers;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will convert the users measurments and generate the BMI of that user. I
    /// It will also dislay messages aimed at vulnerable groups based on those measurments.
    /// </summary>
    /// <author>
    /// Nick Bowley version 0.1
    /// </author>
    public class BMI
    {
        public const string IMPERIAL = "Imperial";
        public const string METRIC = "Metric";

        public const string FEET = "Feet";
        public const string INCHES = "Inches";

        public const int INCHES_IN_FEET = 12;
        public const int POUNDS_IN_STONE = 14;
        public const int IMPERIAL_FACTOR = 703;

        public double BMI_Index { get; set; }
        public BMIStatus Status { get; set; }

        

        private double height;
        private double weight;

        private string unitChoice;

        public void Run()
        {
            Helpers.ConsoleHelper.OutputHeading("BMI Calculator");
            ConvertBMI();
        }

        public void ConvertBMI()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select the Unit");

            string[] choices = new string[]
            {
                IMPERIAL, METRIC
            };

            Console.WriteLine($"\n Select a unit to convert from\n");
            int choice = ConsoleHelper.SelectChoice(choices);
            unitChoice = choices[choice - 1];

            Console.WriteLine($"\n Your Selection Is {unitChoice}!");

            if (unitChoice == IMPERIAL)
            {
                InputImperial();
                CalculateImperial();
            }
            else if (unitChoice == METRIC)
            {
                InputMetric();
                CalculateMetric();
            }

            OutputBMI_Index();

            string input = Console.ReadLine();
        }

        private void InputImperial()

        {

            Console.WriteLine($"\n Please enter your height" +
                " in feet and inches \n ");

            height = ConsoleHelper.InputNumber($"\n Enter your height in feet > \n ");
            int inches = (int)ConsoleHelper.InputNumber($"\n enter inches > \n ", 0, INCHES_IN_FEET);
            height = height * INCHES_IN_FEET + inches;

            Console.WriteLine($"\n Please enter your weight in stones and pounds \n ");

            weight = ConsoleHelper.InputNumber($"\n Enter Stones \n ");
            int pounds = (int)ConsoleHelper.InputNumber($"Enter Pounds > \n ", 0, POUNDS_IN_STONE);
            weight = weight * POUNDS_IN_STONE+ pounds;


        }

        private void InputMetric()

        {
            Console.WriteLine($"\n Please enter your height" +
                    " in metres");

            height = ConsoleHelper.InputNumber($"\n Enter your height in metres > ");

            Console.WriteLine($"\n Please enter your weight in kilograms");

            weight = ConsoleHelper.InputNumber($"\n Enter Kilograms");
        }

        private void CalculateImperial()

        {
            BMI_Index = (weight * IMPERIAL_FACTOR) / (height*height);
        }

        private void CalculateMetric()

        {
            BMI_Index = (weight)/(height*height);
        }

        public void OutputBMI_Index()

        {
            if (BMI_Index < 18.50)
            {
                Status = BMIStatus.UnderWeight;
            }

            else if (BMI_Index > 18.5 && BMI_Index < 24.9)
            {
                Status = BMIStatus.NormalWeight;
            }

            else if (BMI_Index > 25.0 && BMI_Index < 29.9)
            {
                Status = BMIStatus.OverWeight;
            }

            else if (BMI_Index > 30.0 && BMI_Index < 39.9)

            {
                Status = BMIStatus.ObeseII;
            }

            else if (BMI_Index > 40.0)

            {
                Status = BMIStatus.ObeseIII;
            }

            Console.WriteLine($"Your BMI Index is {BMI_Index: 0.00} ");
            Console.WriteLine($"You are {Status.ToString()} ");

        }
        
    }
}

