using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class MultiplicationCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MultiplicationCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}