using ConsoleAppProject.Helpers;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will convert the users measurments and generate the BMI of that user.
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

        

        public double height;
        public double weight;

        private string unitChoice;


        /// <summary>
        /// This method runs the programme
        /// </summary>
        public void Run()
        {
            
            ConvertBMI();
        }


        /// <summary>
        /// This method gives the user a choice of imperial or metric. 
        /// It also presents the main mesage to the user introducing the app
        /// and a messge to BAME groups.
        /// </summary>
        public void ConvertBMI()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" Your BMI, or Body Mass Index, is a measure" +
                " \n of your weight compared to your height." +
                " \n Accurate assessments of obesity are important, as being overweight" +
                " \n or obese significantly increases your risk of a variety of " +
                " \n medical conditions including type 2 diabetes, heart disease and cancer.\r\n\r\n" +
                " \n For most adults, BMI gives a good estimate of your weight-related health risks. " +
                " \n If your BMI is over 35, your weight is definitely putting your health at risk, " +
                " \n regardless of the factors below. However, there are some situations where BMI may " +
                " \n underestimate or overestimate these risks in the 25-35 BMI range. " +
                "" +
                " The main ones are:\r\n 1. Children\r\n 2. Pregnant women.\r\n 3. Muscle Builders\r\n 4." +
                " BAME: Black, Asian and other minority ethnic group");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Select the Unit");

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


        /// <summary>
        /// Asks the user to input thier imperial measurments should that be their choice.
        /// </summary>
        public void InputImperial()

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


        /// <summary>
        /// Asks the user to input their metric measurments should that be thier choice.
        /// </summary>
        public void InputMetric()

        {
            Console.WriteLine($"\n Please enter your height" +
                    " in metres");

            height = ConsoleHelper.InputNumber($"\n Enter your height in metres > ");

            Console.WriteLine($"\n Please enter your weight in kilograms");

            weight = ConsoleHelper.InputNumber($"\n Enter Kilograms");
        }

        /// <summary>
        /// Calculates the users BMI using thier imperial measurments
        /// </summary>
        public void CalculateImperial()

        {
            BMI_Index = (weight * IMPERIAL_FACTOR) / (height*height);
        }

        /// <summary>
        /// Calculates the users BMI using thier metric measurments 
        /// </summary>
        public void CalculateMetric()

        {
            BMI_Index = (weight)/(height*height);
        }


        /// <summary>
        /// This calculates the BMI status of the user using more or less than values.
        /// </summary>
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

            else if (BMI_Index > 25.0 && BMI_Index < 30.0)
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

            Console.WriteLine($"\n Your BMI index is {BMI_Index: 0.00}");
            Console.WriteLine();
            Console.WriteLine($"Your BMI status is {Status}");

            Console.WriteLine("\n If you are Black, Asian, or other minority " +
                "\n ethnic groups, you have a higher risk have a " +
                "\n higher risk of developing some long-term " +
                "\n conditions, such as type 2 diabetes. " +
                "\n These adults with a BMI of:");

            Console.WriteLine("\n 23.0 or more are at increased risk " +
                "\n 27.5 or more are at high risk");



        }
        
    }
}

