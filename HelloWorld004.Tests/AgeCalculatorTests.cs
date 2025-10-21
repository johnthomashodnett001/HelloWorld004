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
        public void CalculateAgeTo100_Age99_Returns1Years()
        {
            // Arrange
            int inputAge = 99;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(1, result.yearsTo100, "When age is 99, years to 100 should be 1 year.");
        }

        [Test]
        public void CalculateAgeTo100_Age1_Returns99Yearss()
        {
            // Arrange
            int inputAge = 1;

            // Act
            var result = AgeCalculator.CalculateAgeTo100(inputAge);

            // Assert
            Assert.AreEqual(99, result.yearsTo100, "When age is 1, years to 100 should be 99 years.");
        }
    }
}