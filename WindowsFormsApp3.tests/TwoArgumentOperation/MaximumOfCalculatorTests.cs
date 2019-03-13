using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class MaximumOfCalculatorTests
    {
        [TestCase(2, 2, 2)]
        [TestCase(-5, 4, 4)]
        [TestCase(-3, 8, 8)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MaximumOfCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
