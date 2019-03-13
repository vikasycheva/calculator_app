using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AdditionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
