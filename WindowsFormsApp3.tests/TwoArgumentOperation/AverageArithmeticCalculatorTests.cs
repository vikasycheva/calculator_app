using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class AverageArithmeticCalculatorTests
    {
        [TestCase(5, 2, 3.5)]
        [TestCase(0, 5, 2.5)]
        [TestCase(-3, -8, -5.5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AverageArithmeticCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
