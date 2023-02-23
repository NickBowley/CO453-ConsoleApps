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
    }
}