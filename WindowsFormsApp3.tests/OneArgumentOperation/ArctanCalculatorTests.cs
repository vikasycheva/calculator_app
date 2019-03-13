using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class ArctanCalculatorTests
    {
        [TestCase(1, 0.78)]
        [TestCase(0.5, 0.46)]
        [TestCase(-1, -0.78)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArctanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
