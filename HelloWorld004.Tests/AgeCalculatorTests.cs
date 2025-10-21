using NUnit.Framework;

namespace HelloWorld004.Tests
{
    [TestFixture]
    public class AgeCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateAgeTo100_Age0_Returns100Years()
        {
            // Arrange
            int inputAge = 0;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(100, result.yearsTo100, "When age is 0, years to 100 should be 100 years.");
            Assert.AreEqual(DateTime.Now.Year + 100, result.yearAt100, "Year at 100 should be current year + 100.");
        }

        [Test]
        public void CalculateAgeTo100_Age1_Returns99Years()
        {
            // Arrange
            int inputAge = 1;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(99, result.yearsTo100, "When age is 1, years to 100 should be 99 years.");
            Assert.AreEqual(DateTime.Now.Year + 99, result.yearAt100, "Year at 100 should be current year + 99.");
        }

        [Test]
        public void CalculateAgeTo100_Age50_Returns50Years()
        {
            // Arrange
            int inputAge = 50;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(50, result.yearsTo100, "When age is 50, years to 100 should be 50 years.");
            Assert.AreEqual(DateTime.Now.Year + 50, result.yearAt100, "Year at 100 should be current year + 50.");
        }

        [Test]
        public void CalculateAgeTo100_Age99_Returns1Year()
        {
            // Arrange
            int inputAge = 99;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(1, result.yearsTo100, "When age is 99, years to 100 should be 1 year.");
            Assert.AreEqual(DateTime.Now.Year + 1, result.yearAt100, "Year at 100 should be current year + 1.");
        }

        [Test]
        public void CalculateAgeTo100_Age100_Returns0Years()
        {
            // Arrange
            int inputAge = 100;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(0, result.yearsTo100, "When age is 100, years to 100 should be 0 years.");
            Assert.AreEqual(DateTime.Now.Year, result.yearAt100, "Year at 100 should be current year.");
        }

        [Test]
        public void CalculateAgeTo100_AgeOver100_ReturnsNegativeYears()
        {
            // Arrange
            int inputAge = 101;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(-1, result.yearsTo100, "When age is 101, years to 100 should be -1 year.");
            Assert.AreEqual(DateTime.Now.Year - 1, result.yearAt100, "Year at 100 should be current year - 1.");
        }

        [Test]
        public void CalculateAgeTo100_MaxIntAge_HandlesExtremeValue()
        {
            // Arrange
            int inputAge = int.MaxValue;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(100 - int.MaxValue, result.yearsTo100, "Should handle maximum integer value.");
            Assert.AreEqual(DateTime.Now.Year + (100 - int.MaxValue), result.yearAt100, "Should calculate correct year for maximum age.");
        }

        [Test]
        public void CalculateAgeTo100_NegativeAge_HandlesNegativeValue()
        {
            // Arrange
            int inputAge = -1;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(101, result.yearsTo100, "When age is -1, years to 100 should be 101 years.");
            Assert.AreEqual(DateTime.Now.Year + 101, result.yearAt100, "Year at 100 should be current year + 101.");
        }
    }
}