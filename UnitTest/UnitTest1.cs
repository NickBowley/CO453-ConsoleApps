using ConsoleAppProject.App01;

namespace UnitTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = "Feet";
            converter.toUnit = "Miles";

            converter.fromDistance = 5280;

            converter.CalculateDistance();

            int expectedDistance = 1;

            Assert.AreEqual(expectedDistance, Convert.ToInt32(converter.toDistance));
        }

        [TestMethod]
        public void TestMilesToMetres()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = "Miles";
            converter.toUnit = "Metres";

            converter.fromDistance = 1;

            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.toDistance));

        }

        [TestMethod]
        public void TestMilesToFeet()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = "Miles";
            converter.toUnit = "Feet";

            converter.fromDistance = 1;

            converter.CalculateDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.toDistance));

        }


        [TestMethod]
        public void TestMetresToFeet()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = "Metres";
            converter.toUnit = "Feet";

            converter.fromDistance = 5;

            converter.CalculateDistance();

            double expectedDistance = 16.4042;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.toDistance));

        }

        [TestMethod]
        public void TestFeetToMetres()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = "Feet";
            converter.toUnit = "Metres";

            converter.fromDistance = 16.4042;

            converter.CalculateDistance();

            double expectedDistance = 5;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.toDistance));

        }

        [TestMethod]
        public void TestMetresToMiles()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = "Metres";
            converter.toUnit = "Miles";

            converter.fromDistance = 1609.34;

            converter.CalculateDistance();

            double expectedDistance = 1;

            Assert.AreEqual(expectedDistance, Convert.ToDouble(converter.toDistance));

        }
    }


}

