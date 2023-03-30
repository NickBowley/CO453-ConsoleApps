using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "Feet";
            converter.ToUnit = "Miles";

            converter.FromDistance = 5280;

            converter.CalculateDistance();

            int expectedDistance = 1;

            Assert.AreEqual(expectedDistance, Convert.ToInt32(converter.ToDistance));
        }

        [TestMethod]
        public void TestMilesToMetres()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "Miles";
            converter.ToUnit = "Metres";

            converter.FromDistance = 1;

            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.ToDistance));

        }

        [TestMethod]
        public void TestMilesToFeet()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "Miles";
            converter.ToUnit = "Feet";

            converter.FromDistance = 1;

            converter.CalculateDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.ToDistance));

        }


        [TestMethod]
        public void TestMetresToFeet()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "Metres";
            converter.ToUnit = "Feet";

            converter.FromDistance = 5;

            converter.CalculateDistance();

            double expectedDistance = 16.4042;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.ToDistance));

        }

        [TestMethod]        public void TestFeetToMetres()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "Feet";
            converter.ToUnit = "Metres";

            converter.FromDistance = 16.4042;

            converter.CalculateDistance();

            double expectedDistance = 5;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.ToDistance));

        }

        [TestMethod]
        public void TestMetresToMiles()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "Metres";
            converter.ToUnit = "Miles";

            converter.FromDistance = 1609.34;

            converter.CalculateDistance();

            double expectedDistance = 1;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.ToDistance));

        }


        [TestClass]
        public class TestBMI
        {
            // Metric Tests
            [TestMethod]
            public void TestMetricUnderweight()
            {
                BMI calculator = new BMI();

                calculator.height = 1.93;
                calculator.weight = 45.5;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 12.22);
            }

            [TestMethod]
            public void TestMetricUnderweightMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 1.57;
                calculator.weight = 45.5;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 18.46);
            }

            [TestMethod]
            public void TestMetricNormalweight()
            {
                BMI calculator = new BMI();

                calculator.height = 1.93;
                calculator.weight = 70.5;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 18.93);
            }

            [TestMethod]
            public void TestMetricNormalweightMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 1.53;
                calculator.weight = 56.8;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 24.26);
            }

            [TestMethod]
            public void TestMetricOverweight()
            {
                BMI calculator = new BMI();

                calculator.height = 1.93;
                calculator.weight = 93.2;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 25.02);
            }

            [TestMethod]
            public void TestMetricOverweightMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 1.53;
                calculator.weight = 68.2;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 29.13);
            }

            [TestMethod]
            public void TestMetricObeseI()
            {
                BMI calculator = new BMI();

                calculator.height = 1.83;
                calculator.weight = 97.7;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 29.17);
            }

            [TestMethod]
            public void TestMetricObeseIMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 1.53;
                calculator.weight = 90.9;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 38.83);
            }

            [TestMethod]
            public void TestMetricObeseII()
            {
                BMI calculator = new BMI();

                calculator.height = 1.55;
                calculator.weight = 97.7;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 40.67);
            }

            [TestMethod]
            public void TestMetricObeseIIMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 1.53;
                calculator.weight = 97.7;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 41.74);
            }

            [TestMethod]
            public void TestMetricObeseIII()
            {
                BMI calculator = new BMI();

                calculator.height = 1.53;
                calculator.weight = 100;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 42.72);
            }

            [TestMethod]
            public void TestMetricObeseIIIMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 1.53;
                calculator.weight = 181.4;

                calculator.CalculateMetric();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 77.49);
            }


            // Imperial Tests
            [TestMethod]
            public void TestImperialUnderweight()
            {
                BMI calculator = new BMI();

                calculator.height = 75.98;
                calculator.weight = 100.3;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 12.21);
            }

            [TestMethod]
            public void TestImperialUnderweightMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 61.81;
                calculator.weight = 100.3;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 18.46);
            }

            [TestMethod]
            public void TestImperialNormalweight()
            {
                BMI calculator = new BMI();

                calculator.height = 75.98;
                calculator.weight = 155.4;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 18.92);
            }

            [TestMethod]
            public void TestImperialNormalweightMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 60.24;
                calculator.weight = 125.2;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 24.25);
            }

            [TestMethod]
            public void TestImperialOverweight()
            {
                BMI calculator = new BMI();

                calculator.height = 75.98;
                calculator.weight = 205.5;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 25.02);
            }

            [TestMethod]
            public void TestImperialOverweightMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 60.24;
                calculator.weight = 150.4;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 29.14);
            }

            [TestMethod]
            public void TestImperialObeseI()
            {
                BMI calculator = new BMI();

                calculator.height = 72.05;
                calculator.weight = 215.4;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 29.17);
            }

            [TestMethod]
            public void TestImperialObeseIMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 60.24;
                calculator.weight = 200.4;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 38.82);
            }

            [TestMethod]
            public void TestImperialObeseII()
            {
                BMI calculator = new BMI();

                calculator.height = 61.02;
                calculator.weight = 215.4;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 40.67);
            }

            [TestMethod]
            public void TestImperialObeseIIMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 60.24;
                calculator.weight = 215.4;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 41.73);
            }

            [TestMethod]
            public void TestImperialObeseIII()
            {
                BMI calculator = new BMI();

                calculator.height = 60.24;
                calculator.weight = 220.5;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 42.72);
            }

            [TestMethod]
            public void TestImperialObeseIIIMaximum()
            {
                BMI calculator = new BMI();

                calculator.height = 60.24;
                calculator.weight = 399.9;

                calculator.CalculateImperial();
                double index = Math.Round(calculator.BMI_Index, 2);

                Assert.AreEqual(index, 77.47);
            }
        }
        [TestClass]
        public class TestStudentGrades
        {
            public readonly StudentGrades
                converter = new StudentGrades();

            public readonly int[] StatsMarks = new int[]
            {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };

            [TestMethod]
            public void TestConvert0ToGradeF()
            {
                // Arrange
                StudentGrades app03 = new StudentGrades();

                //Act
                Grades actualGrade = app03.ConvertToGrade(39);

                // Assert
                Assert.AreEqual(actualGrade, Grades.F);
            }

            [TestMethod]
            public void TestConvert39ToGradeF()
            {
                // Arrange
                Grades expectedGrade = Grades.F;

                //Act
                Grades actualGrade = converter.ConvertToGrade(39);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert40ToGradeD()
            {
                // Arrange
                Grades expectedGrade = Grades.D;

                //Act
                Grades actualGrade = converter.ConvertToGrade(40);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert49ToGradeD()
            {
                Grades expectedGrade = Grades.D;

                //Act
                Grades actualGrade = converter.ConvertToGrade(49);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert50ToGradeC()
            {
                // Arrange
                Grades expectedGrade = Grades.C;

                //Act
                Grades actualGrade = converter.ConvertToGrade(50);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert59ToGradeC()
            {
                // Arrange
                Grades expectedGrade = Grades.C;

                //Act
                Grades actualGrade = converter.ConvertToGrade(59);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert60ToGradeB()
            {
                // Arrange
                Grades expectedGrade = Grades.B;

                //Act
                Grades actualGrade = converter.ConvertToGrade(60);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert69ToGradeB()
            {
                // Arrange
                Grades expectedGrade = Grades.B;

                //Act
                Grades actualGrade = converter.ConvertToGrade(69);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert70ToGradeA()
            {
                // Arrange
                Grades expectedGrade = Grades.A;

                //Act
                Grades actualGrade = converter.ConvertToGrade(70);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestConvert99ToGradeA()
            {
                // Arrange
                Grades expectedGrade = Grades.A;

                //Act
                Grades actualGrade = converter.ConvertToGrade(99);

                // Assert
                Assert.AreEqual(expectedGrade, actualGrade);
            }

            [TestMethod]
            public void TestCalculateMean()
            {
                converter.Marks = StatsMarks;
                double expectedMean = 55.0;
                converter.CalculateStats();

                Assert.AreEqual(expectedMean, converter.Mean);
            }

            [TestMethod]
            public void TestCalculateMin()
            {
                // Arrange
                converter.Marks = StatsMarks;
                int expectedMin = 10;

                // Act
                converter.CalculateStats();

                // Assert
                Assert.AreEqual(expectedMin, converter.Minimum);
            }

            [TestMethod]
            public void TestGradeProfile()
            {
                // Arrange
                converter.Marks = StatsMarks;

                // Act
                converter.CalculateGradeProfile();

                bool expectedProfile;
                expectedProfile = ((converter.GradeProfile[0] == 3) &&
                                   (converter.GradeProfile[1] == 1) &&
                                   (converter.GradeProfile[2] == 1) &&
                                   (converter.GradeProfile[3] == 1) &&
                                   (converter.GradeProfile[4] == 4));
                // Assert
                Assert.IsTrue(expectedProfile);
            }
        }
    }
}



        
    
    
    




