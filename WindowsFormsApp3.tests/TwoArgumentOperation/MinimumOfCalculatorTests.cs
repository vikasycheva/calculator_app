using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class MinimumOfCalculatorTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(-5, 4, -5)]
        [TestCase(-3, 8, -3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinimumOfCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
